using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task 1 - Personal Info Card
            ////: Name: Sara, Age: 21, Height: 1.65, Student: True
            //string name = "sara";
            //int age = 21;
            //double hieght = 1.65;
            //bool student = true;
            //Console.WriteLine("name : "+name);
            //Console.WriteLine("age : " + age);
            //Console.WriteLine("hieght : " + hieght);
            //Console.WriteLine("student : " + student);

            ///////////////////////////////

            ////Task 2 - Rectangle Calculator
            //Console.WriteLine("plese enter lenght");
            //double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("plese enter width");
            //double width = double.Parse(Console.ReadLine());

            //double area = length * width;
            //Console.WriteLine("area :" + area);
            //double perimeter = 2 * (length + width);
            //Console.WriteLine("perimeter : "+ perimeter);
            ///////////////////////////////////////////////

            ////Task 3 - Even or Odd Checker
            //Console.WriteLine("enter the number ");
            //int result = int.Parse(Console.ReadLine());
            //int check = result % 2;
            //if (check == 0)
            //{
            //    Console.WriteLine("the number is event");
            //}
            //else { Console.WriteLine("the numbers is odd"); }

            /////////////////////////////////////////////////
            ////Task 5 - Grade Letter Lookup
            //Console.WriteLine("enter character");
            //char option = char.Parse(Console.ReadLine());
            //bool exist = false;
            //while(exist==false)
            //{
            //    switch (option)
            //    {
            //        case 'A':
            //            Console.WriteLine("Excellent");
            //            break;

            //        case 'B':
            //            Console.WriteLine("VERY GOOD");
            //            break;
            //        case 'C':
            //            Console.WriteLine("GOOD");
            //            break;
            //        case 'D':
            //            Console.WriteLine("PASS");
            //            break;
            //        case 'F':
            //            Console.WriteLine("FAIL");
            //            break;
            //        default:
            //            Console.WriteLine("invalid grade");
            //            break;

            //    }

            //     exist = true;  

            //}

            ////////////////////////////////////////////////////////////////////
            //Task 4 - Voting Eligibility
            Console.WriteLine("ENTER Age");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine(" a valid national ID (true/false)");
            bool validNationl =bool.Parse( Console.ReadLine());
            if(age>=18 && validNationl==true)
            {
                Console.WriteLine("person eligible to vote");
            }




            Console.WriteLine("press any key to continue");
            string key = Console.ReadLine();

        }




    }

}
    

