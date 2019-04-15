﻿using System;
using Newtonsoft.Json;

namespace x42Gui.Utilities
{
    public class JsonObjectException : Exception
    {
        public JsonObjectException(Exception inner, JsonReader reader) : base(inner.Message, inner)
        {
            this.Path = reader.Path;
        }

        public JsonObjectException(string message, JsonReader reader) : base(message)
        {
            this.Path = reader.Path;
        }

        public string Path { get; }
    }
}