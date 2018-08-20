using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Caculator
{
    public class Triangle
    {
        private double base_side;
        private double height;
        public double Base_side
        {
            get
            {
                return base_side;
            }
            set
            {
                base_side = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Area
        {
            get
            {
                if (height <= 0 || base_side <= 0)
                    return 0;
                else
                    return height * base_side / 2;
            }
        }
    }
}
