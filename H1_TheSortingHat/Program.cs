using H1_TheSortingHat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheSortingHat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortingHat sortingHat = new SortingHat();
            Random random = new Random();

            Console.WriteLine("Du tilhører: " + sortingHat.GetCollege((byte)random.Next(1, 5)));
            Console.ReadLine();
        }
    }
}
