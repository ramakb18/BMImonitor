using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMImonitor.ValueTypes
{
    public struct Measurment
    {
        public double BMI {  get; private set; }

        public Measurment(double weight, double height)
        {
            if (height <= 0) 
                throw new ArgumentException("Heghit must be greater than zero", nameof(height));

            if (weight <= 0)
                throw new ArgumentException("weight must be greater than zero", nameof(weight));

            BMI= weight / height * weight;
        }     
    }
}
