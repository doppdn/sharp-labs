using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = new Folder("folder1");
            var listner = new FolderListner();
            folder.Added += listner.Handle;
            folder.Removed += listner.Handle;

            var myData1 = new MyData1("data1");
            var myData2 = new MyData2("data2");
            var myDataFile1 = new MyDataFile1(myData1, "name1");
            var myDataFile2 = new MyDataFile2(myData2, "name2");

            folder.Add(myDataFile1);
            folder.Add(myDataFile2);
            folder.PrintAll();

            folder.Remove(myDataFile1);
            folder.PrintAll();

            //Console.WriteLine("Let`s try find myDataFile2 by name('name2') in the folder:");
            //folder.FindByName("name2");

        }
    }
}
 