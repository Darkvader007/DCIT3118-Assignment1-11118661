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

    public class Triangle
    {

        public int side1;
        public int side2;
        public int side3;




        public void CheckType()
        {
            Console.WriteLine(" Enter the three sides of the triangle:");
            side1 = Convert.ToInt32(Console.ReadLine());
            side2 = Convert.ToInt32(Console.ReadLine());
            side3 = Convert.ToInt32(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Equilateral");
            }
            else if (side1 == side2)
            {
                Console.WriteLine("Isosceles");
            }
            else if (side1 == side3)
            {
                Console.WriteLine("Isosceles");
            }
            else if (side2 == side3)
            {
                Console.WriteLine("Isoceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
    }

}
