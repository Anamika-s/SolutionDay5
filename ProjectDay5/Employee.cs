using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay5
{
    class Employee
    {
        int id;
        string name;
        public virtual void Get()
        {
            Console.WriteLine("Enter ID");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public virtual void Show()
        {
            Console.WriteLine("ID is " + id);
            Console.WriteLine("Name is " + name);
        }
    }
    class PartTimeEmployee : Employee
    {
        string projectName;
        public override void Get()
        {
            Console.WriteLine("Enter projectName");
            projectName = Console.ReadLine();
        }
        public override void Show()
        {
            Console.WriteLine("projectName is " + projectName);
        }
    }
     class FullTimEmployee : Employee
    {
        string manager;
        public override void Get()
        {
            Console.WriteLine("Enter manager");
            manager = Console.ReadLine();
        }
        public override void Show()
        {
            Console.WriteLine("manager is " + manager);


        }
    }
    }
