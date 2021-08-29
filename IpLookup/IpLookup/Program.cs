using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IpLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = @" _  ____  _     ____  ____  _  __ _     ____ 
/ \/  __\/ \   /  _ \/  _ \/ |/ // \ /\/  __\
| ||  \/|| |   | / \|| / \||   / | | |||  \/|
| ||  __/| |_/\| \_/|| \_/||   \ | \_/||  __/
\_/\_/   \____/\____/\____/\_|\_\\____/\_/   
                                         ";
            WebClient webClient1 = new WebClient();
            Console.Title = "IpLookup | made by Zabor40";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter ip here: ");
            string a = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(webClient1.DownloadString("https://api.hackertarget.com/geoip/?q=" + a));
            Console.ReadKey();
        }
    }
}
