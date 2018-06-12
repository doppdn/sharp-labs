using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class FolderException : Exception
    {
        public FolderException(string message)
        {
            Console.WriteLine($"\r\nException occures. Message: {message}\r\n");
        }
    }
}
