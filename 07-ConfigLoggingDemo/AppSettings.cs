using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ConfigLoggingDemo;

class AppSettings
{
    public string AppName { get; set; } = "";
    public int MaxRetries { get; set; }
}