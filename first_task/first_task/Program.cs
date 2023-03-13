using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class employee
    {
        public string first_name;
        public string last_name;
        public string department;
        public string postion;
        public string head_of_department;
        public string address;
        public string personal_email;
        public char gender;
        public int ID;
        public int age;
        public float tax_rate;
        public float net_salary;
        public employee(string first_name)
        {
            this.first_name = first_name;
        }
        public employee(string first_name,string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
        }
        public employee(string first_name, string last_name,string department)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.department = department;
        }
        public employee(string first_name, string last_name, string department,string position)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.department = department;
            this.postion = position;
        }
        public employee(string first_name, string last_name, string department, string position,int age)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.department = department;
            this.postion = position;
            this.age = age;
        }
        public employee(string first_name, string last_name, string department, string position,int age,float net_salary)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.department = department;
            this.postion = position;
            this.age = age;
            this.net_salary = net_salary;
        }
        public void display_fullname() 
        {
            Console.WriteLine(first_name+" "+last_name );
        }
        public void display_HeadOfDepartment()
        {
            Console.WriteLine("doctor\\"+head_of_department);
        }
        public float compute_net_salary(float salary) 
        {
            net_salary = salary * tax_rate;
            return net_salary ;
        }
        public void display_id()
        {
            Console.WriteLine("your ID is : "+ID);
        }
        public void display_rank (employee x)
        {
            Console.WriteLine("the rank of {0} is {1}",x.first_name,x.postion);
        }
        public void display_EmailAddress()
        {
            Console.WriteLine("your email address is {0}",personal_email);
        }
    }
}
