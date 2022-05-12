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

                //Sætter vores option så vi modtager bruger input
                option = Console.ReadLine();

                //Switch case som kontrollere hvad brugere trykker på og sikre at hvis brugeren trykker forkert så får de en fejl besked. 
                switch (option)
                {
                    case "1": // tilføj ny reollejer
                        if (amount < reoler)
                        {
                            Console.WriteLine("Bruger har fået brugerID'et: {0}", amount + 1);
                            Console.Write("Skriv fornavnet på den nye reollejer: ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].FirstName = Console.ReadLine();

                            Console.Write("\nSkriv efternavnet på den nye reollejer: ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].LastName = Console.ReadLine();

                            Console.Write("\nSkriv den nye reollejers e-mail:  ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].Email = Console.ReadLine();

                            Console.Write("\nSkriv den nye reollejers telefon nummer ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].Phone = Console.ReadLine();

                            amount++; //Vi husker at vores tæller nu skal gå op med 1 fordi vi har lavet en ny reollejer.
                            Console.WriteLine();
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
                                Console.WriteLine($"Navn = {reollejer[i].FirstName} {reollejer[i].LastName},  E-Mail = {reollejer[i].Email}, Telefon Nummer = {reollejer[i].Phone}", i + 1);
                            Console.WriteLine();
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
            }
            while (repeating);
        }
    }
}
