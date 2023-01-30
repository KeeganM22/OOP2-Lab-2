using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Entites
{
    internal class PartTime : Employees
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
        public PartTime()
        {

        }

        // constructor
        public PartTime(string id, string name, double rate, string address, string phone, long sin, double hours)
        {
            this.id = id;
            this.name = name;
            this.rate = rate;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.hours = hours;
        }
    }
}
