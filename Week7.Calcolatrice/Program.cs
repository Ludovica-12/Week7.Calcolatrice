using System;
using Week7.Calcolatrice.Core;

namespace Week7.Calcolatrice
{
    class Program
    {
        private static readonly MainBL bl = new MainBL();

        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto!");
            bool continuare = true;

            do
            {
                Console.WriteLine("\nPremi 1 per la somma");
                Console.WriteLine("Premi 2 per la sottrazione");
                Console.WriteLine("Premi 3 per la moltiplicazione");
                Console.WriteLine("Premi 4 per la divisione");
                Console.WriteLine("Premo 5 per vedere se n1 e n1 sono uguali o n1 maggiore di n2");
                Console.WriteLine("Premi q per uscire");
                Console.WriteLine();


                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Somma();
                        break;
                    case "2":
                        Sottrazione();
                        break;
                    case "3":
                        Moltiplicazione();
                        break;
                    case "4":
                        Divisione();
                        break;
                    case "5":
                        ControlloMaggioranzaUguaglianza();
                        break;
                    case "q":
                        Console.WriteLine("Ciao alla prossima");
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata riprova");
                        break;
                }
            } while (continuare);
        }

        private static void ControlloMaggioranzaUguaglianza()
        {
            Console.WriteLine("**Uguali o Maggiore?**\n");

            Console.WriteLine("Inserisci il primo numero:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero:");
            double n2 = double.Parse(Console.ReadLine());

            var esito = bl.VerificaSeAMaggioreDiB(n1, n2);

            if (esito == true)
            {
                Console.WriteLine($"{n1} è maggiore o uguale a {n2}");
            }
            else
            {
                Console.WriteLine($"{n1} non è maggiore e non è uguale a {n2}");
            }
            

            
        }

        private static void Divisione()
        {
            Console.WriteLine("**Hai scelto la Divisione**\n");

            Console.WriteLine("Inserisci il primo numero:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero:");
            double n2 = double.Parse(Console.ReadLine());

            var esito = bl.DividiNumeri(n1, n2);
            Console.WriteLine("\n***Il Risultato è:***");
            Console.WriteLine(esito);

        }

        private static void Moltiplicazione()
        {
            Console.WriteLine("**Hai scelto la Moltiplicazione**\n");

            Console.WriteLine("Inserisci il primo numero:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero:");
            double n2 = double.Parse(Console.ReadLine());

            var esito = bl.MoltiplicaNumeri(n1, n2);
            Console.WriteLine("\n***Il Risultato è:***");
            Console.WriteLine(esito);

        }

        private static void Sottrazione()
        {
            Console.WriteLine("**Hai scelto la Sottrazione**\n");

            Console.WriteLine("Inserisci il primo numero:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero:");
            double n2 = double.Parse(Console.ReadLine());

            var esito = bl.SottraiNumeri(n1, n2);
            Console.WriteLine("\n***Il Risultato è:***");
            Console.WriteLine(esito);

        }

        private static void Somma()
        {
            Console.WriteLine("**Hai scelto la Somma**\n");

            Console.WriteLine("Inserisci il primo numero:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero:");
            double n2 = double.Parse(Console.ReadLine());

            var esito = bl.SommaNumeri(n1, n2);
            Console.WriteLine("\n***Il Risultato è:***");
            Console.WriteLine(esito);
        }
    }
}
