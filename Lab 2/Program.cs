using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Entites;

/*
 * make sure to go to proporties in the txt and set it to always copy
 *
 *
 *
 *
 *Note To Prof
 *I tried using the list made with the Employees class but couldnt get it to work with accepting rates and pay
 *
 *
 *
 */

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "employees.txt";

            string[] lines;
            //usefil thing to know is how to make an a list
            //List<string> files = new List<string>();

            lines = File.ReadAllLines(path);

            List<Employees> employees = new List<Employees>();
            List<Wages> wages1= new List<Wages>();
            List<PartTime> partTime1= new List<PartTime>();
            List<Salaried> sal = new List<Salaried>(); 
            List<double> totalPay = new List<double>();

            foreach (string line in lines)
            {
                // how we can split lines by ","
                // a char would be what we need to use to know where to split
                string[] parts;

                parts = line.Split(':');

                // separating the diffrent parts into what they are going to be called
                string id = parts[0];
                string name = parts[1];
                string address = parts[2];
                string phonenumber = parts[3];
                long sin = long.Parse(parts[4]);
                string date = parts[5];

                

                // finding the first digit
                string firstDigit;
                firstDigit = id.Substring(0, 1);

                //making it into a int so we can better use the if
                // unless you can math it out
                int firstDigitNum = int.Parse(firstDigit);

                if (firstDigitNum >= 0 && firstDigitNum <= 4)
                {
                    // salaried
                    double salary = double.Parse(parts[7]);

                    Salaried salaried;

                    salaried = new Salaried(id, name, salary, address, phonenumber, sin);

                    sal.Add(salaried);
                    employees.Add(salaried);
                    totalPay.Add(salary);
                }
                else if (firstDigitNum >= 8 && firstDigitNum <= 9)
                {
                    // partTime
                    // no overtime pay
                    double partPay = double.Parse(parts[7]);
                    double hours = double.Parse(parts[8]);
                    double partTotal = hours* partPay;
                    
                    PartTime partTime;

                    partTime = new PartTime(id, name, partPay, address, phonenumber, sin, hours);

                    employees.Add(partTime);
                    partTime1.Add(partTime);
                    totalPay.Add(partTotal);

                    

                }
                else if (firstDigitNum >= 5 && firstDigitNum <= 7)
                {
                    // Wage
                    // overtime pay
                    double wagePay = double.Parse(parts[7]);
                    double hours = double.Parse(parts[8]);
                    if (hours > 40)
                    {
                        hours = hours * 1.5;
                    }
                    double wageTotal = hours * wagePay;

                    Wages wages = new Wages(id, name, wagePay, address, phonenumber, sin, hours);

                    employees.Add(wages);
                    wages1.Add(wages);
                    totalPay.Add(wageTotal);
                }

                

                
            }
            
            Wages wage1 = new Wages();
            Salaried salaried1 = new Salaried();
            Employees employees1 = new Employees();

            wage1.GetHeighestWagePay(wages1);
            salaried1.GetLowestSalariedPay(sal);
            salaried1.GetHighestSalariedPay(sal);
            employees1.GetAvgWeeklyPay(totalPay);
            employees1.ListFiles(employees);
            employees1.Percent(employees);

            

            
        }
        
    }
}