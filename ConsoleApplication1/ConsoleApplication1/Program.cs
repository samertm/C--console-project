using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ConsoleApplication1
{
    public delegate void EventHandler(object sender, EventArgs e);

    class Program
    {
        static void Main(string[] args)
        {
            GameMap map = new GameMap();
            Player player = new Player(ref map);

            while (true)
            {
                map.Print();
                Console.Write("Good sir, would you kindly enter a cardinal direction? ");
                player.ParseDirection(ref map, Console.ReadLine());
            }
        }
    }
}