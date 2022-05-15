using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystem
{
    public class MenuFunktion
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
            public int ID;
        }

        public void Menuen()
        {
            //definere hvor mange reoler vi har til leje
            int reoler = 200;
            //Opretter ny reollejer array
            ReolLejer[] reollejer = new ReolLejer[reoler];
            //Opretter en boolean som vi senere bruger til vores do-while loop
            bool repeating = true;

            //Vores counter som holder øje med hvor mange reollejer vi har
            int amount = 0;

            do
            {
                Console.WriteLine();
                //Referer til Dialog og laver et nyt objekt
                Dialog dialog = new Dialog();
                //Kalder dens Welcome metode
                dialog.Welcome();
                //Menu menu = new Menu("Test");
                //menu.
                //Sætter vores option så vi modtager bruger input
                Menu m = new Menu();
                m.ItemCount = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                //Switch case som kontrollere hvad brugere trykker på og sikre at hvis brugeren trykker forkert så får de en fejl besked. 
                switch (m.ItemCount)
                {
                    case 1: // tilføj ny reollejer
                        if (amount < reoler)
                        {
                            Console.WriteLine("Antal reollejer i systemet = {0}\n", amount + 1);

                            dialog.dialogUniMessage("Indtast fornavn: ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].FirstName = Console.ReadLine();
                            dialog.dialogUniMessage("\nIndtast efternavn: ");

                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].LastName = Console.ReadLine();
                            dialog.dialogUniMessage("\nIndtast e-mail: ");

                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].Email = Console.ReadLine();
                            dialog.dialogUniMessage("\nIndtast telefonnummer: ");
                            //Sætter vores oprettet array = brugerens input
                            reollejer[amount].Phone = Console.ReadLine();

                            //generer et random ID til den tilføjet reollejer
                            Random random = new Random();
                            reollejer[amount].ID = random.Next(1, 99999);
                            Console.Write($"\nReollejerens auto-genereret ID er: {reollejer[amount].ID}");
                            Console.ReadLine();

                            amount++; //Vi husker at vores tæller nu skal gå op med 1 fordi vi har lavet en ny reollejer.

                            dialog.dialogUniMessage("\nReollejer tilføjet!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else //Hvis der er mere end de 200 reoler udlejet, så får brugeren denne besked.
                        {
                            dialog.dialogUniMessage("Ingen ledige reoler");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    // vis alle reollejer
                    case 2:
                        if (amount == 0) //Sikre at hvis der ingen reollejere er oprettet, så ser brugeren denne besked
                        {
                            dialog.dialogUniMessage("Der findes ingen reollejere");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else //Men hvis der er én eller flere reollejere, så kører vi igennem vores for-loop og displayer informationen om alle de fundne reollejere
                             //Med andre ord, vi iterere igennem vores array og displayer alt i arrayet.
                        {
                            for (int i = 0; i < amount; i++)
                            
                            Console.WriteLine($"Navn = {reollejer[i].FirstName} {reollejer[i].LastName}\nE-Mail = {reollejer[i].Email}\nTelefon Nummer = {reollejer[i].Phone}\nID: {reollejer[i].ID}\n", i + 1);
                            dialog.dialogUniMessage("\nTryk på en vilkårlig tast for at vende tilbage til menuen: ");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 0: //Afslut programmet
                        program_001_Exit();
                        break;
                    default: //Default hvis brugeren trykker på noget forkert ser de denne besked (bruger venlighed)
                        program_002_Default();
                        break;
                }
            } while (repeating);
        }

        public static void program_004_test()
        {

        }

        public static void program_003_test()
        {

        }

        public static void program_002_Default()
        {
            Dialog dialog = new Dialog();
            dialog.dialogUniMessage("Forkert valg. Prøv venligst igen\n");
            Console.ReadLine();
            Console.Clear();
        }
        public static void program_001_Exit()
        {
            Dialog dialog = new Dialog();
            dialog.dialogUniMessage("Programmet lukker ned. Tak for denne gang!");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
