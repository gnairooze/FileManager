using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileManager
{
    public class LineReadEventArgs: EventArgs
    {
        public string CurrentLine { get; set; }
        public string Header { get; set; }
    }
}
