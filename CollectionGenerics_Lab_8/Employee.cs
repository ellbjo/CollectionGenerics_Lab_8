using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerics_Lab_8
{
    public class Employee
    {
        //Private variables
        private int id = 0;
        private string name = "";
        private string gender = "";
        private double salary = 0;


        //Constructor for the Employee-object 
        public Employee(int id, string name, string gender, double salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        //Default constructor
        public Employee()
        {
        }

        //Property with setter and getter for salary. Has logic to check if value is over 0 if you're trying to change salary
        public double Salary
        {
            get 
            { 
                return salary; 
            }
            set 
            { 
                if(value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary has to be higher then 0.");
                }
            }
        }

        //Property with setter and getter for gender, if gender is not set returns a warning instead of gender
        //If value is null or empty when trying to change gender, a warning will be printed in console and the value will not be set
        public string Gender
        {
            get 
            {
                if (string.IsNullOrEmpty(gender))
                {
                    return "Gender is not set";
                }
                else
                {
                    return gender;
                }
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Gender has to have a value");
                }
                else
                {
                    gender = value;
                } 
            }
        }

        //Property with setter and getter for name, if name is not set returns a warning instead of name
        //If value is null or empty when trying to change name, a warning will be printed in console and the value will not be set

        public string Name
        {
            get 
            {
                if (string.IsNullOrEmpty(name))
                {
                    return "Name is not set";
                }
                else
                {
                    return name;
                }
            }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name has to have a value");
                }
                else
                {
                    name = value;
                }
            }
        }

        //Property with setter and getter for ID. Has logic to check if value is over 0 if you're trying to change ID-variable
        public int Id
        {
            get 
            { 
                return id; 
            }
            set 
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Id has to be higher then 0.");
                }
            }
        }

        //Overrides the default use of ToString
        public override string ToString()
        {
            return Id.ToString() + " - " + Name + " - " + Gender + " - " + Salary;
        }

    }
} 
