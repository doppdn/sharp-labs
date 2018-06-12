using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class MyDataFile1 : File
    {
        public MyData1 myData1 { get; set; }

        public MyDataFile1(MyData1 _myData1, string name)
        {
            myData1 = _myData1;
            Name = name;
            Text = myData1.Text;

        }        

        public override object DeepCopy()
        {
            var obj = new MyDataFile1(myData1, Name);
            obj.Text = Text;
            return obj;
        }
    }
}
