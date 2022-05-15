using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystem
{
    internal class Controller
    {
        //definere hvor mange reoler vi har til leje
        public int reoler = 200;
        //Opretter ny reollejer array
        
        //Opretter en boolean som vi senere bruger til vores do-while loop
        public bool repeating = true;

        //Vores counter som holder øje med hvor mange reollejer vi har
        public int amount = 0;


        public Controller()
        {
            ReolLejer[] reollejer = new ReolLejer[reoler];
        }


        public static void testtest()
        {

        }

    }

    

}
