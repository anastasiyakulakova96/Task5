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
            LinkedListClass linkedListClass = new LinkedListClass();
            CollectionsTimeTest col = new CollectionsTimeTest();

            Console.WriteLine("Please,wait");

            Logger.CountOfElements();
            col.AddCollections();
            col.TimeTestForAdd();
            col.TimeTestForGet();
            col.TimeTestForRemove();
            col.TimeTestForSearch();

            Console.WriteLine($"Perform the functions of the time you can see {Logger.pathWithNameFile} ");

            Logger.GetLogger().Close();

            Console.ReadLine();
        }
    }
}
