using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2.Entites
{
    internal class Wages : Employees 
    {
        // fields
        private double rate;
        private long sin;
        private double hours;

        // proporties
        public double Rate
        {
            get { return rate; }
        }
        public double Hours
        {
            get { return hours; }
        }

        // constructor
        public Wages()
        {

        }
        public Wages(string id, string name, double rate, string address, string phone, long sin, double hours)
        {
            this.id = id;
            this.name = name;
            this.rate = rate;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.hours = hours;
        }

        //methods
        public void GetHeighestWagePay(List<Wages> avgW)
        {
            double max = 0;
            double maxPay = 0;
            string maxName = "x";


            foreach (Wages wage in avgW)
            {
                double fullPay = wage.hours * wage.rate;
                if (fullPay > max)
                {
                    max = fullPay;
                    maxName = wage.name;
                    maxPay = fullPay;

                }


            }
            Console.WriteLine("the Highest payed wage employee is: " + maxName + " with a pay of: $" + maxPay);
        }



        public void GetLowestWagePay(List<Wages> avgW)
        {
            double min = 999999999999;
            double minPay = 0;
            string minName = "x";


            foreach (Wages wage in avgW)
            {
                double fullPay = wage.hours * wage.rate;
                if (fullPay < min)
                {
                    min = fullPay;
                    minName = wage.name;
                    minPay = fullPay;

                }


            }
            Console.WriteLine("the lowest payed wage employee is: " +minName + " with a pay of: $" + minPay);
        }

    }
}
