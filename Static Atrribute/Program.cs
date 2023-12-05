using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Atrribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs holiday = new songs("Holiday", "Green Day");
            Songs kashmir = new songs("Holiday", "Green Day");

            Console.WriteLine(Songs.songCount);
            Console.ReadLine();

        }
    }
}
