
namespace x42Gui.Utilities.JsonErrors
{
    public class ErrorResult 
    {
        public int StatusCode { get; set; }
        public ErrorResponse ErrorResponse { get; set; }
        public ErrorResult(int statusCode, ErrorResponse value)
        {
            this.StatusCode = statusCode;
            this.ErrorResponse = value;
        }
    }
}
