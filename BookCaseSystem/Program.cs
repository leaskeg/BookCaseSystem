using System;

namespace BookCaseSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dialog dialog = new Dialog();
                dialog.UserID("Welcome \nIndtast brugerID: ");
               

                Search search = new Search(50520);
                search.userID = Int32.Parse(Console.ReadLine());
                Console.WriteLine(search.userID);
               
                Console.WriteLine(search.bookCaseBarCode);
                Console.ReadLine();
            }
        }
    }
}
