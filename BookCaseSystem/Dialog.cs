using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystem
{
    internal class Dialog
    {
        //velkommen besked
        public void Welcome()
        {

            //Fancy logo lig mærke til at jeg bruger @ foran "" så logoet kan tage flere linjer ellers får man problemer.
            Console.WriteLine(@"
         ██████╗ ███████╗ ██████╗ ██╗     ███╗   ███╗ █████╗ ██████╗ ██╗  ██╗███████╗██████╗ ███████╗████████╗
         ██╔══██╗██╔════╝██╔═══██╗██║     ████╗ ████║██╔══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗██╔════╝╚══██╔══╝
         ██████╔╝█████╗  ██║   ██║██║     ██╔████╔██║███████║██████╔╝█████╔╝ █████╗  ██║  ██║█████╗     ██║   
         ██╔══██╗██╔══╝  ██║   ██║██║     ██║╚██╔╝██║██╔══██║██╔══██╗██╔═██╗ ██╔══╝  ██║  ██║██╔══╝     ██║   
         ██║  ██║███████╗╚██████╔╝███████╗██║ ╚═╝ ██║██║  ██║██║  ██║██║  ██╗███████╗██████╔╝███████╗   ██║   
         ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═════╝ ╚══════╝   ╚═╝ ");
            // credit: http://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20
            Console.WriteLine();
            //Standard menu punkter
            dialogUniMessage("1. Tilføj ny reollejer\n2. Vis alle reollejere\n0. Afslut programmet\nAngiv dit valg: ");

        }

        //universal besked generator
        public void dialogUniMessage(string message)
        {
            Console.WriteLine(message);
        }
    } 
}

