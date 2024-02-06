using System;

namespace quiz1
{



    class Person
    {

        public String pangan { get; set; }

        public int timbang { get; set; }
    }





    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();



            while (true)
            {
                Console.WriteLine("Enter your new Data Y/N");

                if (Console.ReadLine() == "N")
                {
                    break;
                }
                Person person1 = new Person();
                Console.WriteLine("Enter Name: ");
                person1.pangan = Console.ReadLine();
                Console.WriteLine("Enter Weight: ");
                person1.timbang = int.Parse(Console.ReadLine());

                list.Add(person1);




            }
            list.ForEach(x =>
            {
                Console.WriteLine(x.pangan);
                Console.WriteLine(x.timbang);
                Console.WriteLine("===================");

            });
        }

    }
}

