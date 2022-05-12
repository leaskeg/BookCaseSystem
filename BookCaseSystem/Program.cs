using System;

namespace BookCaseSystem
{
    internal class Program
    {


        static void Main(string[] args)
        {



            //dialog.dialogUniMessage("Welcome \nIndtast brugerID: ");
            MenuFunktion menu = new MenuFunktion();
            menu.Menuen();



        }
    }
}


// ældre funktioner: 

/*

            //dialog.dialogUniMessage("Welcome \nIndtast brugerID: ");
            MenuFunktion menu = new MenuFunktion();
                menu.Menuen();





                // --------- Search
                //opret ny Search objekt
                Search search = new Search();

                //indsæt bruger ID i search
                //search.userID = Int32.Parse(Console.ReadLine());

                //vis userID og bookCaseBarCode fra Search class
                Console.WriteLine("userID: " + search.userID);
                Console.WriteLine("randomBarcode: " + search.bookCaseBarCode);
 
 
 
 */