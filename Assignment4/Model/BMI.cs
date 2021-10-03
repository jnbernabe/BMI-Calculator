using Assignment4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Model
{
    public class BMI : IBMI
    {
        public string First { get; set; }
        public string Last { get; set; }

        public int Feet { get; set; }
        public int Inches { get; set; }
        public int Meters { get; set; }
        public int Weight { get; set; }

        public UnitType Units { get; set; }

        public DateTime? DoB { get; set; }


        public BMI() 
        { 
            
        }

    }

    public enum UnitType{
            Metric,
            Imperial

        }

}
