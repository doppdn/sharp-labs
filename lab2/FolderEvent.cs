using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    delegate void FolderStateHandler(Folder sender, FolderEventArgs e);
    class FolderEventArgs
    {
        public string Message { get; }
        public File File { get; }

        public FolderEventArgs(string message, File file)
        {
            Message = message; File = file;
        }
    }
}
