using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5.EsercizioPratico
{
     /*abstract*/ class Employee : Person
    {
        //Impiegato
        public SectorEnum Sector { get; set; }

        //Calcolo stipendio
        //public abstract int CalcoloStipendio(); 
        //TODO: creo un metodo astratto, rendendo anche la classe stessa astratta,per poi implementarlo nelle classi che erdetitano questa classe

        public Employee(string firstName, string lastName, string cf, SectorEnum sector)
            :base (firstName, lastName, cf)
        {
            Sector = sector;
        }

        public Employee()
        {

        }

    }

    public enum SectorEnum
    {
        Sales,
        Administration,
        Development
    }

}
