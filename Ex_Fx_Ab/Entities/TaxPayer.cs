using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_Fx_Ab.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualInCome { get; set; }
        public List<TaxPayer> taxPayers { get; set; }

        public TaxPayer()
        {
        }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualInCome = anualIncome;
        }

        public void AddTaxPayer(TaxPayer taxPayer)
        {
            taxPayers.Add(taxPayer);
        }

        public void RemoveTaxPayer(TaxPayer taxPayer)
        {
            taxPayers.Remove(taxPayer);
        }

        public abstract double Tax();

        public virtual string TaxView()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
