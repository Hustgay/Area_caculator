using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Caculator
{
    class Rectangle
    {
        private double length;
        private double width;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public double Area
        {
            get
            {
                if (length <= 0 || width <= 0)
                    return 0;
                else
                    return width * length;
            }
        }
    }
}
