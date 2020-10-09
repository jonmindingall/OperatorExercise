using System;

namespace OperatorExercise
{
    
    class CalculateArea
    {
        public double areaOfCircle(double r)
        {
            double area = Math.PI * (r * r);
            return area;

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            int b;
            int quotient;
            
            a = 17;
            b = 4;
            quotient = a / b;
            int remainder = a % b;
            CalculateArea s = new CalculateArea();
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double area = s.areaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
            

        }
        
    }
}
