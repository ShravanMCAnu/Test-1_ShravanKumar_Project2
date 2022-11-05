using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project2
{
    public class ElectricityBill 
    {
        public string CustomerName { get; set; }
        public string MeterNumber { get; set; }

        double BillAmount;
        public void CalculateElectricityBill(int _units, string _serviceType)
        {
            if (_serviceType == "d" ||_serviceType=="D")
            {


                if (_units < 100)
                {
                    BillAmount = _units * 0.35;
                }
                else if (_units < 200)
                {
                    BillAmount = _units * 0.85;
                }
                else if (_units < 400)
                {
                    BillAmount = _units * 1.15;
                }
                else if (_units < 700)
                {
                    BillAmount = _units * 2.05;
                }
                else
                {
                    BillAmount = _units * 2.80;
                }
            }
            else
            {
                if (_units < 100)
                {
                    BillAmount = _units * 0.90;
                }
                else if (_units < 200)
                {
                    BillAmount = _units * 1.35;
                }
                else if (_units < 400)
                {
                    BillAmount = _units * 1.95;
                }
                else if (_units < 700)
                {
                    BillAmount = _units * 2.45;
                }
                else
                {
                    BillAmount = _units * 3.25;
                }
            }
            Console.WriteLine("--ELECTRICITY BILL DETAILS--");
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Meter Number : " + MeterNumber);
            Console.WriteLine("Electricity Bill  is: "+BillAmount.ToString("0.00"));
        }
    }
}
