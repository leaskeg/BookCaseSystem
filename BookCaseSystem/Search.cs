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

        public Search(int userID)
        {
            int FinalUserID = userID;

            bookCaseBarCode = BookCaseBarCodeGen();


            
        }

        public double BookCaseBarCodeGen()
        {
            Random random = new Random();
            double bookCaseBarCodeID = random.Next(0, 99999);

            return bookCaseBarCodeID;
        }

    }
}
