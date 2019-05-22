using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorUtils
{
    public class FileDialogClosedEventArgs : EventArgs
    {
        public string Path { get; set; }
        public FileDialogClosedEventArgs(string path)
        {
            Path = path;
        }
    }
}
