using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Caculator
{
    public class Square
    {
        private double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public double Area
        {
            get
            {
                if (side <= 0)
                    return 0;
                else return side * side;
            }
        }
    }
}
