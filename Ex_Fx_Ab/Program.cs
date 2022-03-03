using System;
using Ex_Fx_Ab.Entities;
using System.Globalization;

namespace Ex_Fx_Ab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.WriteLine();

                Console.Write("Individual or company (i/c): ");
                char opc = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if(opc == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthEx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, healthEx));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, income, employees));
                }

                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
            }

            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.TaxView());
            }

            /*double TotalTax, sum;

            foreach (TaxPayer taxPayer in list)
            {

                TotalTax += sum
            }*/
        }
    }
}