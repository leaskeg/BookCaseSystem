using System;

namespace BookCaseSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


                // --------- DIALOG
                //opret en ny Dialog objekt
                Dialog dialog = new Dialog();

                //Velkomst besked:
                //dialog.dialogUniMessage("Welcome \nIndtast brugerID: ");
                MenuFunktion menu = new MenuFunktion();
                menu.Menuen();

                // --------- DIALOG
                //afsluttende besked, rens skærm efter tryk
                dialog.dialogUniMessage("Programmet er slut tryk for at prøv igen ");
                Console.ReadLine();
                Console.Clear();
            
        }
    }
}


/*

                // --------- Search
                //opret ny Search objekt
                Search search = new Search();

                //indsæt bruger ID i search
                //search.userID = Int32.Parse(Console.ReadLine());

                //vis userID og bookCaseBarCode fra Search class
                Console.WriteLine("userID: " + search.userID);
                Console.WriteLine("randomBarcode: " + search.bookCaseBarCode);
 
 
 
 */