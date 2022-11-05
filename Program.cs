// See https://aka.ms/new-console-template for more information
using Test1_ShravanKumar_Project2;

ElectricityBill objElectricityBill=new ElectricityBill();
Console.WriteLine("Enter Customer Name");
objElectricityBill.CustomerName = Console.ReadLine();
Console.WriteLine("Enter Meter Number like., eg: TS14361");
objElectricityBill.MeterNumber = Console.ReadLine();
Console.WriteLine("Enter Number of units");
int units = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Service Type, For Domestic 'd' or For Commercial 'c' ");
string serviceType = Console.ReadLine();
objElectricityBill.CalculateElectricityBill(units, serviceType);