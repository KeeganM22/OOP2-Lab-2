using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab_2.Entites
{
    internal class Employees
    {
        // fields
        protected string id;
        protected string name;
        protected string date;
        protected string address;
        protected string phone;

        //proporties
        public string Id 
        {
            get { return id; } // or get => return id
        }
        public string Name
        {
            get { return name; }
        }
        public Employees()
        {

        }
        //constructor
        public Employees(string id, string name, string date, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.address = address;
            this.phone = phone;
        }
        public void GetAvgWeeklyPay(List<double> payments)
        {
            double avg = payments.Average();
            Console.WriteLine("the average pay for the week is: $" + avg);
        }
        public void ListFiles(List<Employees> list)
        {
            foreach (Employees employees in list)
            {
                Console.WriteLine(employees.id + " " + employees.Name + " " + employees.address+ " " + employees.phone);
            }
        }
        
        public void Percent(List<Employees> list)
        {
            decimal totalWag = 1;
            decimal totalPart = 1;
            decimal totalSal = 1;
            decimal total = list.Count;
            List<Employees> numberWages = new List<Employees>();
            List<Employees> numberPart = new List<Employees>();
            List<Employees> numberSal = new List<Employees>();
            foreach (Employees employees in list)
            {
                if (employees is Wages)
                {
                    numberWages.Add((Wages) employees);
                    totalWag = numberWages.Count;
                    


                }
                else if (employees is PartTime)
                {
                    numberPart.Add((PartTime) employees);
                    totalPart = numberPart.Count;
                    
                }
                else
                {
                    numberSal.Add(employees);
                    totalSal = numberSal.Count;
                    
                }
            }
            
            decimal percentWag = (totalWag / total) * 100;
            Console.WriteLine(percentWag + "%");
            decimal percentPart = (totalPart / total) * 100;
            Console.WriteLine(percentPart + "%");
            decimal percentSal = (totalSal / total) * 100;
            Console.WriteLine(percentSal + "%");
        }
    }
}
