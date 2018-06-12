using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class MyDataFile2 : File
    {
        public MyData2 myData2 { get; set; }

        public MyDataFile2(MyData2 _myData2, string name)
        {
            myData2 = _myData2;
            Name = name;
            Text = myData2.Text;

        }        

        public override object DeepCopy()
        {
            var obj = new MyDataFile2(myData2, Name);
            obj.Text = Text;
            return obj;
        }
    }
}
