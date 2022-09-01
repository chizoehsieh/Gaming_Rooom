using System;

namespace HW8
{
    public class Pass
    {
        private int _times;
        private string _str;
        public int times
        {
            set { _times = value; }
            get { return _times; }
        }
        public string str
        {
            set { _str = value; }
            get { return _str; }
        }
    }
}
