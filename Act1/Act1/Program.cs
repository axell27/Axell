using System;

namespace Activity1
{
    public class Math
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("Addition: "+ (num1 + num2));
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine("Subtraction: "+ (num1 - num2));
        }
        public void Mul(int num1, int num2)
        {
            Console.WriteLine("Multiplication: "+ (num1 * num2));
        }
        public void Div(int num1, int num2)
        {
            Console.WriteLine("Division: "+ (num1 / num2));
        }
    }
    public class Program
    { 
    static void Main(string[] args)
        {
            int num1, num2;
            Math math = new Math(); 
          
           

            Console.WriteLine("Enter num1: ");
            num1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = int.Parse (Console.ReadLine());

            math.Add(num1, num2);
            math.Sub(num1, num2);
            math.Mul(num1, num2);
            math.Div(num1, num2);
        }
    }
}