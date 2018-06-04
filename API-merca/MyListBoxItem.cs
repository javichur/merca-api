using System;

namespace API_merca
{
    internal class MyListBoxItem
    {
        public MyListBoxItem()
        {
            
        }

        public Object Tag { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}