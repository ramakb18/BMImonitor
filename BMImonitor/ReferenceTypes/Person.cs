using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMImonitor.ReferenceTypes
{
    public class Person
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public double  Height { get; set; } 
        public double  Weight { get; set; } 

        public double  BMI
        {
            get
            {
                var measurment = new BMImonitor.ValueTypes.Measurment(Weight, Height);
                return measurment.BMI;
            }
        }
    }
}
