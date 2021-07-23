using System;

namespace Week2Day5.EsercizioPratico
{
    internal class Menu
    {
        internal static void Start()
        {
            Console.WriteLine("Benvenuto");

            Person person;
            char option;

            do
            {
                Console.WriteLine("Premi 1) Per visualizzare tutti gli impiegati");
                Console.WriteLine("Premi 2) Per visualizzare gli impiegati per settore");
                Console.WriteLine("Premi 3) Inserisci un nuovo impiegato");
                Console.WriteLine("Premi 4) Elimina un impiegato");
                Console.WriteLine("Premi 'q' per uscire");

                option = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (option)
                {
                    case '1':
                        //Visualizza gli impiegati
                        UserManager.PrintEmployee();
                        break;
                    case '2':
                        //Visualizza gli impiegati per settore
                        UserManager.PrintSector();
                        break;
                    case '3':
                        //Inserisci un nuovo impiegato
                        AddAccount();
                        break;
                    case '4':
                        //Elimina l'impiegato
                        DeleteAccount();
                        break;
                    case 'q':
                        Console.WriteLine("\n Ciao alla prossima!");
                        return;
                    default:
                        Console.WriteLine("Scelta non disponibile. Riprova!");
                        break;

                }



            } while (!(option == 'q'));
        }

        private static void DeleteAccount()
        {
            string name;
            Console.WriteLine("Quale dipendente vuoi eliminare?");

            do
            {
                Console.WriteLine("Inserisci il CF del dipendente");
                name = Console.ReadLine();

            } while (name.Length == 0);

            Employee e = UserManager.Delete(name);

            if (e != null)
            {
                UserManager.DeleteEmployeed(e);
            }
            else
            {
                Console.WriteLine("Non esiste un evento con questo titolo");
            }

        }

        private static void AddAccount()
        {
            string name;

            Console.WriteLine("Quale dipendente vuoi aggiungere?");

            do
            {
                Console.WriteLine("Inserisci il Nome del dipendente");
                name = Console.ReadLine();

            } while (name.Length == 0);

            do
            {
                Console.WriteLine("Inserisci il Cognome del dipendente");
                name = Console.ReadLine();

            } while (name.Length == 0);

            do
            {
                Console.WriteLine("Inserisci il CF del dipendente");
                name = Console.ReadLine();

            } while (name.Length == 0);

            do
            {
                Console.WriteLine("Inserisci la mansione del dipendente");
                name = Console.ReadLine();

            } while (name.Length == 0);

            Employee e = new Employee { /*TODO: Creare la lista per il nuoo dipendente*/};

            UserManager.AddAccount(e);
        }
    }
}