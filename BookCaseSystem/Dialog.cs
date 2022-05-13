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
            Menu mainMenu = new Menu(@"
         ██████╗ ███████╗ ██████╗ ██╗     ███╗   ███╗ █████╗ ██████╗ ██╗  ██╗███████╗██████╗ ███████╗████████╗
         ██╔══██╗██╔════╝██╔═══██╗██║     ████╗ ████║██╔══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗██╔════╝╚══██╔══╝
         ██████╔╝█████╗  ██║   ██║██║     ██╔████╔██║███████║██████╔╝█████╔╝ █████╗  ██║  ██║█████╗     ██║   
         ██╔══██╗██╔══╝  ██║   ██║██║     ██║╚██╔╝██║██╔══██║██╔══██╗██╔═██╗ ██╔══╝  ██║  ██║██╔══╝     ██║   
         ██║  ██║███████╗╚██████╔╝███████╗██║ ╚═╝ ██║██║  ██║██║  ██║██║  ██╗███████╗██████╔╝███████╗   ██║   
         ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═════╝ ╚══════╝   ╚═╝ ");

            mainMenu.MenuItems = new MenuItem[10];
            mainMenu.AddMenuItem("", 0);
            mainMenu.AddMenuItem("1. Tilføj ny reollejer", 1);
            mainMenu.AddMenuItem("2. Vis alle reollejere", 2);
            mainMenu.AddMenuItem("3. Vis Reoler", 3);
            mainMenu.AddMenuItem("4. test", 4);


            mainMenu.Show();

        }

        //universal besked generator
        public void dialogUniMessage(string message)
        {
            Console.WriteLine(message);
        }
    } 
}

