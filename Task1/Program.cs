using System.ComponentModel.DataAnnotations;

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

            //Task 2 - Rectangle Calculator
            Console.WriteLine("plese enter lenght");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("plese enter width");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine("area :" + area);
            double perimeter = 2 * (length + width);
            Console.WriteLine("perimeter : "+ perimeter);





        }
    }
}
