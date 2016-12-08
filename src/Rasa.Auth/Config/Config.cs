﻿using System.Collections.Generic;

namespace Rasa.Config
{
    using Data;

    public class Config
    {
        public string DatabaseConnectionString { get; set; }
        public AuthListType AuthListType { get; set; }
        public Dictionary<string, string> Servers { get; set; }
        public SocketAsyncConfig SocketAsyncConfig { get; set; }
        public AuthConfig AuthConfig { get; set; }
        public CommunicatorConfig CommunicatorConfig { get; set; }
        public Logger.LoggerConfig LoggerConfig { get; set; }
    }
}
