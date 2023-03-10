using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter weight in KG: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight <= 0 || weight > 635)
            {
                Console.WriteLine($"{weight}?! it seems unnatural...");
                Console.Write("Please enter weight in KG: ");
                weight = Convert.ToDouble(Console.ReadLine());

            }

            Console.Write("Please enter hight in CM: ");
            double hight = Convert.ToDouble(Console.ReadLine());

            if (hight <= 0 || hight > 272)
            {
                Console.WriteLine($"{hight}?! it seems unnatural...");
                Console.Write("Please enter hight in CM: ");
                hight = Convert.ToDouble(Console.ReadLine());

            }

            hight = hight / 100;

            // * Declare weight in Kg and hight in CM
            // * After: Convert hight from CM to Meters

            double BMI = weight / (hight * hight);
            BMI = Math.Round(BMI, 2);

            // *  Math.Round Method limits decimal digits

            if (BMI < 18.5)
            {
                Console.WriteLine($"Your BMI is equal to {BMI}, and you are underweight.");
            }

            else if (BMI >= 18.5 & BMI < 25)
            {
                Console.WriteLine($"Your BMI is equal to {BMI}, and you are normal.");
            }

            else if (BMI >= 25 & BMI < 30)
            {
                Console.WriteLine($"Your BMI is equal to {BMI}, and you are overweight.");
            }

            else if (BMI >= 30 & BMI < 35)
            {
                Console.WriteLine($"Your BMI is equal to {BMI}, and you are obese.");
            }

            else
            {
                Console.WriteLine($"Your BMI is equal to {BMI}, and you are extremely obese.");
            }
        }
    }
}
