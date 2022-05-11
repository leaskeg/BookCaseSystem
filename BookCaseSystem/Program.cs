using System;

namespace BookCaseSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //opret en ny Dialog objekt
                Dialog dialog = new Dialog();

                //Velkomst besked:
                dialog.UserID("Welcome \nIndtast brugerID: ");
                
                //opret ny Search objekt
                Search search = new Search(50520);

                //indsæt bruger ID i search
                search.userID = Int32.Parse(Console.ReadLine());

                //vis userID
                Console.WriteLine("userID: " + search.userID);
                Console.WriteLine("randomBarcode: " + search.bookCaseBarCode);

                //afsluttende besked
                dialog.UserID("Programmet er slut tryk for at prøv igen ");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
