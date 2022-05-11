using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystem
{
    public class Search
    {
        //
        //variabler:
        public double bookCaseBarCode { get; set; }
        public int userID { get; set; }

        //
        //Search constructor(CTOR), tager imod userID, men bruger det ikke. 
        public Search(int userID)
        {
            int FinalUserID = userID;

            bookCaseBarCode = BookCaseBarCodeGen();
        }

        //
        //Metoder:
        public double BookCaseBarCodeGen()
        {
            //laver random, som er en instans af klassen random
            Random random = new Random();

            //laver en variabel bookCaseBarCodeID, som bliver sat til random
            //som laver et tilfældigt tal fra 10000 til 99999
            double bookCaseBarCodeID = random.Next(10000, 99999);

            //retunere stregkode
            return bookCaseBarCodeID;
        }

    }
}
