using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 70.2;
            double hight = 182;

            hight = hight / 100;

            // * Declare weight in Kg and hight in CM
            // * After: Convert hight to Meters

            double BMI = weight / (hight * hight);
            BMI = Math.Round(BMI, 2);

            // * Math.Round Method limits decimal digits

            Console.WriteLine($"Your BMI is {BMI}");
        }
    }
}
