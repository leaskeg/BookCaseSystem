using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystem
{
    internal class MenuFunktion
    {
        //Ikke færdig implementeret endnu
        //opretter en struct som indeholder vores skabalon for vores reollejer
        //flyttes over til Reollejer klassen
        public struct ReolLejer
        {
            public string FirstName;
            public string Email;
            public string LastName;
            public string Phone;
        }

        public void Menuen()
        {
            //definere hvor mange reoler vi har til leje
            int reoler = 200;
            //Opretter ny reollejer array
            ReolLejer[] reollejer = new ReolLejer[reoler];
            //Opretter en boolean som vi senere bruger til vores do-while loop
            bool repeating = true;
            //Vores string i do-while som senere i koden bliver sat = Console.ReadLine(); og indtager input fra brugeren
            string option;
            //Vores counter som holder øje med hvor mange reollejer vi har
            int amount = 0;

            do
            {
                Console.WriteLine();
                //Referer til Dialog og laver et nyt objekt
                Dialog dialog = new Dialog();
                //Kalder dens Welcome metode
                dialog.Welcome();
                //Sætter vores option så vi modtager bruger input
                option = Console.ReadLine();
                Console.Clear();
                //Switch case som kontrollere hvad brugere trykker på og sikre at hvis brugeren trykker forkert så får de en fejl besked. 
                switch (option)
                {
                    case "1": // tilføj ny reollejer
                        if (amount < reoler)
                        {
                            Console.WriteLine("Antal reollejer i systemet = {0}\n", amount + 1);
                            
                            Console.Write("Indtast fornavn: ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].FirstName = Console.ReadLine();

                            Console.Write("\nIndtast efternavn:  ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].LastName = Console.ReadLine();

                            Console.Write("\nIndtast e-mail:  ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].Email = Console.ReadLine();

                            Console.Write("\nIndtast telefonnummer:  ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].Phone = Console.ReadLine();

                            amount++; //Vi husker at vores tæller nu skal gå op med 1 fordi vi har lavet en ny reollejer.

                            Console.WriteLine("\nReollejer tilføjet!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else //Hvis der er mere end de 200 reoler udlejet, så får brugeren denne besked.
                        {
                            Console.WriteLine("Ingen ledige reoler");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    // vis alle reollejer
                    case "2":
                        if (amount == 0) //Sikre at hvis der ingen reollejere er oprettet, så ser brugeren denne besked
                        {
                            Console.WriteLine("\nDer findes ingen reollejere");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else //Men hvis der er én eller flere reollejere, så kører vi igennem vores for-loop og displayer informationen om alle de fundne reollejere
                             //Med andre ord, vi iterere igennem vores array og displayer alt i arrayet.
                        {
                            for (int i = 0; i < amount; i++)
                                Console.WriteLine($"Navn = {reollejer[i].FirstName} {reollejer[i].LastName}\nE-Mail = {reollejer[i].Email}\nTelefon Nummer = {reollejer[i].Phone}\n", i + 1);
                            Console.WriteLine("\nTryk på en vilkårlig tast for at vende tilbage til menuen: ");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "0": //Afslut programmet
                        Console.WriteLine("Programmet lukker ned. Tak for denne gang!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default: //Default hvis brugeren trykker på noget forkert ser de denne besked (bruger venlighed)
                        Console.WriteLine();
                        Console.WriteLine("Forkert valg. Prøv venligst igen\n");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (repeating);
        }
    }
}
