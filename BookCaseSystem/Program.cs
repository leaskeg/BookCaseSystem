using System;

namespace BookCaseSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loop 1.0.0
            while (true)
            {
                // --------- DIALOG
                //opret en ny Dialog objekt
                Dialog dialog = new Dialog();

                //Velkomst besked:
                dialog.dialogMessage("Welcome \nIndtast brugerID: ");

                // --------- Search
                //opret ny Search objekt
                Search search = new Search(Int32.Parse(Console.ReadLine()));

                //indsæt bruger ID i search
                //search.userID = Int32.Parse(Console.ReadLine());

                //vis userID og bookCaseBarCode fra Search class
                Console.WriteLine("userID: " + search.userID);
                Console.WriteLine("randomBarcode: " + search.bookCaseBarCode);

                // --------- DIALOG
                //afsluttende besked, rens skærm efter tryk
                dialog.dialogMessage("Programmet er slut tryk for at prøv igen ");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
