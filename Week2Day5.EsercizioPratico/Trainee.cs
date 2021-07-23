using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5.EsercizioPratico
{
    class Trainee : Employee
    {
        //Stagista
        public int MonthsWorked { get; set; }

        //Calcolo stipendio
        //public override int CalcoloStipendio()
        //{

        //}
        //TODO: Implemento il metodo astratto della classe madre facendo l'override
        public Trainee(string firstName, string lastName, string cf, SectorEnum sector, int mWork)
            : base(firstName, lastName, cf, sector)
        {
            MonthsWorked = mWork;
        }

        public Trainee()
        {

        }

    }
}
