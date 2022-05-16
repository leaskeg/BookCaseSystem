using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystem
{
    internal class Dialog
    {
        //velkomst besked
        public void Welcome()
        {
            Console.WriteLine(@"
         ██████╗ ███████╗ ██████╗ ██╗     ███╗   ███╗ █████╗ ██████╗ ██╗  ██╗███████╗██████╗ ███████╗████████╗
         ██╔══██╗██╔════╝██╔═══██╗██║     ████╗ ████║██╔══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗██╔════╝╚══██╔══╝
         ██████╔╝█████╗  ██║   ██║██║     ██╔████╔██║███████║██████╔╝█████╔╝ █████╗  ██║  ██║█████╗     ██║   
         ██╔══██╗██╔══╝  ██║   ██║██║     ██║╚██╔╝██║██╔══██║██╔══██╗██╔═██╗ ██╔══╝  ██║  ██║██╔══╝     ██║   
         ██║  ██║███████╗╚██████╔╝███████╗██║ ╚═╝ ██║██║  ██║██║  ██║██║  ██╗███████╗██████╔╝███████╗   ██║   
         ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═════╝ ╚══════╝   ╚═╝ ");
            Menu mainMenu = new Menu();
            mainMenu.MenuItems = new MenuItem[10];
            mainMenu.AddMenuItem("", 0);
            mainMenu.AddMenuItem("1. Tilføj ny reollejer", 1);
            mainMenu.AddMenuItem("2. Vis alle reollejere", 2);
            mainMenu.AddMenuItem("3. Søg efter reollejer via. ID", 3);
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

