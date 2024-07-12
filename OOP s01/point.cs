using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s01
{
    internal struct Point
    {
        private int x;
        private int y;

      public Point(int _x ,int _y)
        {
            x = _x;
            y = _y;
        }
     public int X
        { 
            get { return x; }
            set { x = value; }
        }
     public int Y
        {
            get { return x;  }
            set { y = value; }
        }
    
        public override string ToString()
        {
            return $"[X : {x} ,Y : {y} ]";
        }
        



    }
}
