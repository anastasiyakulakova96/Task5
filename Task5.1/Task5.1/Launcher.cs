using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Launcher
    {

        static void Main(string[] args)
        {
            CalculatorForTime col = new CalculatorForTime();

            Console.WriteLine("Please,wait");

            Logger.CountOfElements();
            col.AddCollections();
            col.CalculateTime();

            Console.WriteLine($"Perform the functions of the time you can see {Logger.pathWithNameFile}. For exit press any symbol ");

            Logger.GetLogger().Close();

            Console.ReadLine();
        }
    }
}
