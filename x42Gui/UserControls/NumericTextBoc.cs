using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace x42Gui.UserControls
{
    class NumericTextBox : TextBox
    {
        bool skipEvent = false;

        int decimalCount = 0;

        NumberFormatInfo numberFormatInfo;
        string decimalSeparator;
        string groupSeparator;
        string negativeSign;
        int[] groupSize;

        [Description("Сколько знаков после запятой"), Category("Misc")]
        public uint Decimals { get; set; } = 8;
        [Description("Разрешить отрицательные значения"), Category("Misc")]
        public bool AllowNegativeSign { get; set; } = false;
        [Description("Разрешить десятичные числа"), Category("Misc")]
        public bool AllowDecimal { get; set; } = false;
        [Description("Разрешить сепаратор"), Category("Misc")]
        public bool AllowSeparator { get; set; } = false;

        public int IntValue
        {
            get
            {
                try
                {
                    return Int32.Parse(this.Text, NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign);
                }
                catch (FormatException e)
                {
                    return 0;
                }
                catch (OverflowException e)
                {
                    return 0;
                }
            }
        }

        public decimal DecimalValue
        {
            get
            {
                try
                {
                    return Decimal.Parse(this.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign);
                }
                catch (FormatException e)
                {
                    return 0;
                }
            }
        }

        public NumericTextBox()
        {
            numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            groupSeparator = numberFormatInfo.NumberGroupSeparator;
            groupSize = numberFormatInfo.NumberGroupSizes;
            negativeSign = numberFormatInfo.NegativeSign;
        }

        // Restricts the entry of characters to digits (including hexadecimal), the negative sign, 
        // the decimal point, and editing keystrokes (backspace). 
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                UpdateText(keyInput);
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                UpdateText(keyInput);
                e.Handled = true;
            }
            // Allows one decimal separator as input. 
            // else if (keyInput.Equals(decimalSeparator))
            else if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (AllowDecimal)
                {
                    // UpdateText(e.KeyChar);
                    UpdateText(decimalSeparator);
                }
                e.Handled = true;
            }
            // Application should support a method to temporarily 
            // change input modes to allow input of decimal 
            // character on widest range of keyboards, especially 
            // 12-key keyboards (no Sym button). InputMode will reset 
            // to Numeric after next key press. 
            // Alternative method: 
            // else if (Char.IsPunctuation(e.KeyChar)) 
            else if (keyInput.Equals("*"))
            {
                if (AllowDecimal && decimalCount == 0)
                {
                    skipEvent = true;
                }
                e.Handled = true;
            }
            // Allows separator. 
            else if (keyInput.Equals(groupSeparator))
            {
                if (AllowSeparator)
                {
                    UpdateText(keyInput);
                }
                e.Handled = true;
            }
            // Allows negative sign if the negative sign is the initial character. 
            else if (keyInput.Equals(negativeSign))
            {
                if (AllowNegativeSign) {
                    UpdateText(keyInput);
                }
                e.Handled = true;
            }

            else if (e.KeyChar == '\b')
            {
                // Allows Backspace key.
            }

            else if (e.KeyChar == '\r')
            {
                UpdateText(keyInput);
                // Validate input when Enter key is pressed. 
                // Take other action.
            }

            else
            {
                // Consume this invalid key and beep.
                e.Handled = true;
                // MessageBeep();
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (skipEvent)
            {
                skipEvent = false;
                return;
            }
        }



        // Checks current input characters 
        // and updates control with valid characters only. 
        public void UpdateText(string newKey)
        {
            decimalCount = 0;
            int separatorCount = 0;
            string input;

            if (this.SelectionLength == 0)
            {
                input = this.Text.Insert(this.SelectionStart, newKey); 
            }
            else
            {
                input = this.Text.Remove(this.SelectionStart, this.SelectionLength); 
                input = input.Insert(this.SelectionStart, newKey); 
            }

            if (input.Length > this.MaxLength)
                input = input.Remove(this.MaxLength);


            string updatedText = "";
            int cSize = 0;

            // NOTE: Supports decimalSeparator with a length == 1. 
            char token = decimalSeparator.ToCharArray()[0];
            string[] groups = input.Split(token);

            // Returning input to left of decimal. 
            char[] inputChars = groups[0].ToCharArray();
            // Reversing input to handle separators. 
            char[] rInputChars = inputChars.Reverse().ToArray();
            StringBuilder sb = new StringBuilder();

            bool validKey = false;

            for (int x = 0; x < rInputChars.Length; x++)
            {

                if (rInputChars[x].ToString().Equals(groupSeparator))
                {
                    continue;
                }

                // Checking for decimalSeparator is not required in 
                // current implementation. Current implementation eliminates 
                // all digits to the right of extraneous decimal characters. 
                if (rInputChars[x].ToString().Equals(decimalSeparator))
                {
                    if (!AllowDecimal | decimalCount > 0)
                    {
                        continue;
                    }
                }

                if (rInputChars[x].ToString().Equals(negativeSign))
                {
                    // Ignore negativeSign unless processing first character. 
                    if (x < (rInputChars.Length - 1))
                    {
                        continue;
                    }
                    sb.Insert(0, rInputChars[x].ToString());
                    x++;
                    continue;
                }

                if (AllowSeparator)
                {
                    // NOTE: Does not support multiple groupSeparator sizes. 
                    if (cSize > 0 && cSize % groupSize[0] == 0)
                    {
                        sb.Insert(0, groupSeparator);
                        separatorCount++;
                    }
                }

                // Maintaining correct group size for digits. 
                if (Char.IsDigit(rInputChars[x]))
                {
                    // Increment cSize only after processing groupSeparators.
                    cSize++;
                    validKey = true;
                }

                if (validKey)
                {
                    sb.Insert(0, rInputChars[x].ToString());
                }

                validKey = false;
            }

            updatedText = sb.ToString();

            if (AllowDecimal && groups.Length > 1)
            {
                char[] rightOfDecimals = groups[1].ToCharArray();
                StringBuilder sb2 = new StringBuilder();
                uint lengthRight = (uint)rightOfDecimals.GetLength(0);
                uint length = lengthRight > Decimals ? Decimals : lengthRight;

                for (int i = 0; i < length; i++)
                {
                    if (Char.IsDigit(rightOfDecimals[i]))
                    {
                        sb2.Append(rightOfDecimals[i]);
                    }
                }
                updatedText += decimalSeparator + sb2.ToString();
            }
            // Updates text box. 
            this.Text = updatedText;
            // Updates cursor position. 
            this.SelectionStart = this.Text.Length;
        }
    }
}
