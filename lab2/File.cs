using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;


namespace lab2
{
    public abstract class File
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public abstract object DeepCopy();

        public static bool operator ==(File obj1, File obj2)
        {
            return !(obj1 is null) && obj1.Equals(obj2);
        }

        public static bool operator !=(File obj1, File obj2)
        {
            return (obj1 is null) && !obj1.Equals(obj2);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is File))
                return false;
            var w = obj as File;
            return w.Name == Name && w.Text == Text;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Text.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

          public virtual object Open() 
        {
            return null;
        }

        public virtual string Read()
        {
            return Text;
        }

        public virtual void Write(string s)
        {
            Text = s;
        }
        public virtual int GetLength()
        {
            return Text.Length;
        }
    }
}
