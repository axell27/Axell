using System;
using System.Collections.Generic; 

namespace Quiz1
{
    class Person
    {
        public String Name { get; set; }
        public int Weight { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            int totalWeight = 0; 

            while (true)
            {
                Console.WriteLine("Enter your new Data Y/N");

                if (Console.ReadLine() == "N")
                {
                    break;
                }
                Person person1 = new Person();
                Console.WriteLine("Enter Name: ");
                person1.Name = Console.ReadLine();
                Console.WriteLine("Enter Weight: ");
                person1.Weight = int.Parse(Console.ReadLine());

                list.Add(person1);

                totalWeight += person1.Weight; 

            }

           

            list.ForEach(x =>
            {
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Weight);
                Console.WriteLine("\n==================\n");
          
                
            });
            Console.WriteLine("Total Weight: " + totalWeight);
        }
    }
}