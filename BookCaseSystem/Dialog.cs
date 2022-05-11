using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystem
{
    internal class Dialog
    {
        //velkommen besked
        public void Welcome()
        {

        }

        //universal besked generator
        public void dialogUniMessage(string message)
        {
            Console.WriteLine(message);
        }
        public struct ReolLejer
        {
            public string FirstName;
            public string Email;
            public string LastName;
            public string Phone;
        }

        public void Menu()
        {
                int reoler = 200;
                ReolLejer[] reollejer = new ReolLejer[reoler];
                bool repeating = true;
                string option;
                int amount = 0;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine(@"

         ██████╗ ███████╗ ██████╗ ██╗     ███╗   ███╗ █████╗ ██████╗ ██╗  ██╗███████╗██████╗ ███████╗████████╗
         ██╔══██╗██╔════╝██╔═══██╗██║     ████╗ ████║██╔══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗██╔════╝╚══██╔══╝
         ██████╔╝█████╗  ██║   ██║██║     ██╔████╔██║███████║██████╔╝█████╔╝ █████╗  ██║  ██║█████╗     ██║   
         ██╔══██╗██╔══╝  ██║   ██║██║     ██║╚██╔╝██║██╔══██║██╔══██╗██╔═██╗ ██╔══╝  ██║  ██║██╔══╝     ██║   
         ██║  ██║███████╗╚██████╔╝███████╗██║ ╚═╝ ██║██║  ██║██║  ██║██║  ██╗███████╗██████╔╝███████╗   ██║   
         ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═════╝ ╚══════╝   ╚═╝ ");
                // http://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20
                    Console.WriteLine();
                    Console.WriteLine("1. Tilføj ny reollejer");
                    Console.WriteLine("2. Vis alle reollejere");
                    Console.WriteLine("0. Afslut programmet");
                    Console.Write("\nAngiv dit valg: ");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "1": // tilføj ny reollejer
                            if (amount < reoler)
                            {
                                Console.WriteLine("Bruger har fået brugerID'et: {0}", amount + 1);
                                Console.Write("Skriv fornavnet på den nye reollejer: ");
                                reollejer[amount].FirstName = Console.ReadLine();

                                Console.Write("\nSkriv efternavnet på den nye reollejer: ");
                                reollejer[amount].LastName = Console.ReadLine();

                                Console.Write("\nSkriv den nye reollejers e-mail:  ");
                                reollejer[amount].Email = Console.ReadLine();

                                Console.Write("\nSkriv den nye reollejers telefon nummer ");
                                reollejer[amount].Phone = Console.ReadLine();

                                
                                amount++;
                                Console.WriteLine();
                            }
                         else
                         {
                            Console.WriteLine("Ingen ledige reoler");
                            Console.ReadLine();
                            Console.Clear();
                         }
                            break;

                        // vis alle reollejer
                        case "2":
                            if (amount == 0)
                        {
                            Console.WriteLine("\nDer findes ingen reollejere");
                            Console.ReadLine();
                            Console.Clear();
                        }   
                            else
                            {
                                for (int i = 0; i < amount; i++)
                                Console.WriteLine($"Navn = {reollejer[i].FirstName} {reollejer[i].LastName},  E-Mail = {reollejer[i].Email}, Telefon Nummer = {reollejer[i].Phone}", i + 1);
                                Console.WriteLine();
                            }
                            break;
                    case "0":
                        Console.WriteLine("Programmet lukker ned. Tak for denne gang!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Forkert valg. Prøv venligst igen\n");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                while (repeating);
            }
        }
    }

