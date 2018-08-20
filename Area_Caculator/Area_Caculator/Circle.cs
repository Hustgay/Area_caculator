using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Caculator
{  
    public class Circle
    {
        const double Pi = 3.1415926;
        private double diameter;
        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if (value <= 0) diameter = 0;
                else diameter = value;
            }
        }
        public double Area
        {
            get
            {   
                return Pi * diameter * diameter/4;
            }
        }
    }
}
