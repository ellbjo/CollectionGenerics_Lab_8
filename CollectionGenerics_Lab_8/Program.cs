using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerics_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //creates employee-objects
            Employee employee1 = new Employee(1, "Harry", "Male", 10000);
            Employee employee2 = new Employee(2, "Hermione", "Female", 50000);
            Employee employee3 = new Employee(3, "Myrtle", "Female", 500);
            Employee employee4 = new Employee(4, "Ron", "Male", 100000);
            Employee employee5 = new Employee(5, "Albus", "Male", 25000);


            Console.WriteLine("Part 1");
            Console.WriteLine("---------------------------------------------");

            //Creates a new stack
            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            
            foreach(Employee emp in employeeStack)
            {
                Console.WriteLine(emp);
                Console.WriteLine("Items left in stack - " + employeeStack.Count);
            }

            
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Retrieve Using Pop Method");

            Console.WriteLine("Items left in stack - " + employeeStack.Count);
            Console.WriteLine(employeeStack.Pop());
            Console.WriteLine("Items left in stack - " + employeeStack.Count);
            Console.WriteLine(employeeStack.Pop());
            Console.WriteLine("Items left in stack - " + employeeStack.Count);
            Console.WriteLine(employeeStack.Pop());
            Console.WriteLine("Items left in stack - " + employeeStack.Count);
            Console.WriteLine(employeeStack.Pop());
            Console.WriteLine("Items left in stack - " + employeeStack.Count);
            Console.WriteLine(employeeStack.Pop());
            Console.WriteLine("Items left in stack - " + employeeStack.Count);

            //Adds employees to stack again
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Retrieve Using Peek Method");


            Console.WriteLine(employeeStack.Peek());
            Console.WriteLine("Items left in stack - " + employeeStack.Count);
            Console.WriteLine(employeeStack.Peek());
            Console.WriteLine("Items left in stack - " + employeeStack.Count);
            Console.WriteLine("---------------------------------------------");

            if (employeeStack.Contains(employee3))
            {
                Console.WriteLine("Object 3 EXISTS in stack: " + employee3);
            }
            else
            {
                Console.WriteLine("Object 3 does Not exist in stack");
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Part 2");
            Console.WriteLine("---------------------------------------------");

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            //Uses contains to check if object exist in list
            Console.WriteLine("Checks if " + employee2.Name + " is in list");
            if (employeeList.Contains(employee2))
            {
                Console.WriteLine(employee2.Name + " EXISTS in list");
            }
            else
            {
                Console.WriteLine(employee2.Name + " does NOT exist in list");

            }
            
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Looks for the FIRST object with gender Male");
            Console.WriteLine(employeeList.Find(x => x.Gender == "Male"));

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Looks for ALL objects with gender Male");
            foreach (var male in employeeList.FindAll(x => x.Gender == "Male"))
            {
                Console.WriteLine(male);
            }
            Console.ReadLine();
        }
    }
}
