using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystem
{
    public class Search
    {
        public double bookCaseBarCode { get; set; }
        public int userID { get; set; }

        public Search()
        {
            try
            {
                userID = Int32.Parse(Console.ReadLine());
                bookCaseBarCode = BookCaseBarCodeGen();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Forkert brugerID. Indtast et gyldigt brugerID og forsøg igen.");
                Console.ReadLine();
            }       
        }

        public double BookCaseBarCodeGen()
        {
            Random random = new Random();
            double bookCaseBarCodeID = random.Next(0, 99999);

            return bookCaseBarCodeID;
        }

    }
}
