using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
        public class Grade
        {

            public int grade;


            public void Checkgrade()
            {
                Console.WriteLine("Enter Your Grade (from 0 - 100):");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid Grade");
                }
                else if (grade >= 90)
                {
                    Console.WriteLine(" Grade A");
                }
                else if (grade > 79 && grade < 90)
                {
                    Console.WriteLine(" Grade B");
                }
                else if (grade > 69 && grade < 80)
                {
                    Console.WriteLine(" Grade C");
                }
                else if (grade > 59 && grade < 70)
                {
                    Console.WriteLine("Grade D");
                }
                else
                {
                    Console.WriteLine(" Grade F");
                }

            }
        }

    public class Ticket
    {

        public int age;
        public string TicketPrice = "10 cedis";


        public void CheckPrice()
        {
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 12 || age >= 65)
            {
                TicketPrice = " 7 cedis";
            }

            Console.WriteLine($"{TicketPrice}");

        }
    }

}
