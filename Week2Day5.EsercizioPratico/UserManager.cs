using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5.EsercizioPratico
{
    class UserManager
    {
        static List<Employee> employess = new List<Employee>()
        {
            new Technician{FirstName = "Mario", LastName = "Rossi", CF = "RSSMR63K51H571R"},

            new Trainee{FirstName = "Luca", LastName = "Gialli",CF = "GLLSMR63K51H571R"},

            new Manager{FirstName = "Sara", LastName = "Verdi", CF = "VRDSMR63K51H571R"},



        };

        internal static void PrintEmployee()
        {
            //TODO: Ciclo la lista per andarmi a stampare tutti i dipendenti
        }

        internal static void PrintSector()
        {
            //TODO: Stampo le mansioni
        }

        internal static Employee Delete(string name)
        {
            foreach (Employee e in employess)
            {
                if (e.CF == name)
                    return e;
            }
            return null;
        }

        internal static void DeleteEmployeed(Employee e)
        {
            employess.Remove(e);
        }

        internal static void AddAccount(Employee e)
        {
            employess.Add(e); 
        }
    }
}
