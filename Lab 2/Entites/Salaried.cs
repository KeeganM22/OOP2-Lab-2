using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Entites
{
    internal class Salaried : Employees
    {
        // fields
        private double salary;
        private long sin;

        // proporties
        public double Salary
        {
            get { return salary; }
        }

        // constructor
        public Salaried()
        {

        }

        public Salaried(string id, string name, double salary, string address, string phone, long sin)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
        }


        public void GetHighestSalariedPay(List<Salaried> sal)
        {
            double max = 0;
            double maxPay = 0;
            string maxName = "x";


            foreach (Salaried salaried in sal)
            {


                if (salaried.salary > max)
                {
                    max = salaried.salary;
                    maxName = salaried.name;
                    maxPay = salaried.salary;

                }


            }
            Console.WriteLine("the Highest payed Salaried employee is: " + maxName + " with a pay of: $" + maxPay);


        }
        public void GetLowestSalariedPay(List<Salaried> sal)
        {
            double min = 9999999;
            double minPay = 0;
            string minName = "x";


            foreach (Salaried salaried in sal)
            {

                if (salary < min)
                {
                    min = salaried.salary;
                    minName = salaried.name;
                    minPay = salaried.salary;

                }


            }
            Console.WriteLine("the Lowest payed Salaried employee is: " + minName + " with a pay of: $" + minPay);

        }
    }
}

