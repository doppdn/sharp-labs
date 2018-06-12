using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class Folder
    {
        private List<File> _files;
        private readonly string _name;

        public event FolderStateHandler Added;
        public event FolderStateHandler Removed;

        public Folder(string name)
        {
            _name = name;
            _files = new List<File>();
        }

        public string GetName()
        {
            return _name;
        }

        public void Add(File file)
        {
            if (_files.Contains(file)) 
                throw new FolderException("Can't add to folder. Such file already exist.");
            _files.Add(file);
            Added?.Invoke(this, new FolderEventArgs("Added", file));
        }

        public void Remove(File file)
        {
            if (!_files.Contains(file))
                throw new FolderException("Can't remove from folder. File does not exist at the folder.");
            _files.Remove(file);
            Removed?.Invoke(this, new FolderEventArgs("Removed", file));
        }

        public File FindByName(string name)
        {
            if (!_files.Exists(w => w.Name == name))
                throw new FolderException("Can't find file in folder.");
            var file = _files.Find(w => w.Name == name);
            return file;
        }

        public void PrintAll()
        {            
            Console.WriteLine($"\nList of files in the {GetName()}:");
            Console.WriteLine("/////////////");


            foreach (var file in _files)
            {
                Console.WriteLine($"{file.GetType().Name}: {file}");
            }

            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\n");

        }

    }
}
