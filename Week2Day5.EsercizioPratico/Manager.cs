using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5.EsercizioPratico
{
    class Manager :Employee
    {
        //Manager
        public int Extraordinary { get; set; }
        public int BasicSalary { get; set; }

        //Calcolo stipendio
        //public override int CalcoloStipendio()
        //{

        //}
        //TODO: Implemento il metodo astratto della classe madre facendo l'override
        public Manager(string firstName, string lastName, string cf, SectorEnum sector, int extraordinary, int bSalary)
            : base(firstName, lastName, cf, sector)
        {
            Extraordinary = extraordinary;
            BasicSalary = bSalary;
        }

        public Manager()
        {

        }
    }
}
