using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5.EsercizioPratico
{
     class Technician : Employee
    {
        //Tecnico
        public int HourlyPay { get; set; }
        public int HoursWorked { get; set; }

        //Calcolo stipendio
        //public override int CalcoloStipendio()
        //{

        //}
        //TODO: Implemento il metodo astratto della classe madre facendo l'override
        public Technician(string firstName, string lastName, string cf, SectorEnum sector, int hpay, int hWork)
            : base (firstName, lastName, cf, sector)
        {
            HourlyPay = hpay;
            HoursWorked = hWork;
        }

        public Technician()
        {

        }

    }
}
