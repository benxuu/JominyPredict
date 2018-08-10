using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JominyPredict
{
    class myEvent
    {
    }
    public class myEventArgs : EventArgs
    {
        public myEventArgs(string string1 = "", int intNum = 0)
        {
            this.str1 = string1;
            this.int1 = intNum;
        }
        public string str1
        {
            get;
            set;
        }
        public int int1
        {
            get;
            set;
        }
    }
}
