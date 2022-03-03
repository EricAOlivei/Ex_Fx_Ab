using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Fx_Ab.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax, health;

            if(AnualInCome < 20000.00)
            {
                tax = AnualInCome * 0.15;
            }
            else
            {
                tax = AnualInCome * 0.25;
            }

            if(HealthExpenditures != null)
            {
                health = HealthExpenditures * 0.5;
            }
            else
            {
                health = 0.0;
            }

            return tax - health;
        }
    }
}
