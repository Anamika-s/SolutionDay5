using System;

namespace ProjectDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("SQUARE");
            //Square square = new Square();

            //square.GetDimensions();
            //square.CalculateArea();
            //square.DisplayArea();


            //Console.WriteLine("RECTANGLE");
            //Rectangle rectangle = new Rectangle();

            //rectangle.GetDimensions();
            //rectangle.CalculateArea();
            //rectangle.DisplayArea();

            //Console.WriteLine("TRIANGLE");
            //Triangle triangle = new Triangle();
            //triangle.GetDimensions();
            //triangle.CalculateArea();
            //triangle.DisplayArea();

            //////Shape shape = new Shape ();
            ////Shape shape = new Square();
            ////shape.GetDimensions();
            ////shape.CalculateArea();
            ////shape.DisplayArea();
            ///
            ///

            Console.WriteLine("EMPLOYEE BASE CLASS");
            Employee employee = new Employee();
            employee.Get();
            employee.Show();
            Console.WriteLine("PARTTIME");
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            employee = partTimeEmployee;
            employee.Get();
            employee.Show();

            FullTimEmployee fullTimEmployee = new FullTimEmployee();
            employee = fullTimEmployee;
            employee.Get();
            employee.Show();


        }
    }
}
