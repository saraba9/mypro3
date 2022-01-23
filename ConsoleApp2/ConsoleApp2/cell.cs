using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class cell
    {
        int value;
        bool marked;
        bool opened;
       
        public cell(int value, bool marked)
        {
            this.value = value;
            this.marked = marked;
            this.opened = false;
        }

        public int GetValue()
        {
            return this.value;
        }

        public bool GetMarked()
        {
            return this.marked;
        }

        public bool GetOpened()
        {
            return this.opened;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }
        public void SetValue(int value,char c)
        {
            this.value = this.value +value;
        }
        public void SetMarked(bool marked)
        {
            this.marked = marked;
        }

        public void SetOpened(bool opened)
        {
            this.opened = opened;
        }
    }
}
