using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class FolderListner
    {
        public void Handle(Folder sender, FolderEventArgs args)
        {
            Console.WriteLine($"Folder {sender.GetName()}: {args.Message} {args.File}");
        }
    }
}
