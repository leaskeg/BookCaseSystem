using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseSystem
{
    public class Menu
    {
        public string Title { get; set; }
        public int ItemCount = 0;
        public MenuItem[] MenuItems = new MenuItem[10];

        public Menu(string titleMenu)
        {
            Title = titleMenu;
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine(Title + "\n");
                for (int i = 0; i < ItemCount; i++)
                {

                    Console.WriteLine("  " + MenuItems[i].Title);

                }
                Console.WriteLine("\n(Tryk menupunkt eller 0 for at afslutte)");

                ItemCount = SelectMenuItem(Convert.ToInt32(Console.ReadLine()));

                //ItemCount = SelectMenuItem(1);
                Console.Clear();
                break;
            }

        }
        public void AddMenuItem(string TitleTest, int num)
        {
            MenuItem mi = new MenuItem(TitleTest);
            MenuItems[num] = mi;
            ItemCount++;
        }
        public int SelectMenuItem(int itemNum)
        {

            if (itemNum <= 0)
            {
                itemNum = 0;
            }
            if (itemNum >= ItemCount)
            {
                itemNum = ItemCount;
            }

            return itemNum;

        }
    }
}
