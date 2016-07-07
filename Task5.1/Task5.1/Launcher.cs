using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Launcher
    {
        // private static Logger logger;
        static void Main(string[] args)
        {
            //Launcher launcher = new Launcher();
            ListClass listClass = new ListClass();
            LinkedListClass linkedListClass = new LinkedListClass();
            DictionaryClass dictionaryClass = new DictionaryClass();
            QueueClass queueClass = new QueueClass();
            StackClass stackClass = new StackClass();
            SortedSetClass sortedSetClass = new SortedSetClass();
            SortedDictionaryClass sortedDictionaryClass = new SortedDictionaryClass();

            Console.WriteLine($"Perform the functions of the time you can see {Logger.pathWithNameFile} ");

            listClass.AddElementsInList();
            listClass.ReadItemsFromList();
            listClass.RemoveElementsInList();
            listClass.SearchItemsInList();


            linkedListClass.AddElementsInLinkedList();
            linkedListClass.ReadItemsFromLinkedList();
            linkedListClass.RemoveElementsInLinkedList();
            linkedListClass.SearchItemsInLinkedList();

            dictionaryClass.AddElementsInDictionary();
            dictionaryClass.ReadItemsFromDictionary();
            dictionaryClass.RemoveElementsInDictionary();
            dictionaryClass.SearchItemsInDictionaryt();

            queueClass.AddElementsInQueue();
            queueClass.ReadItemsFromQueue();
            queueClass.RemoveElementsInQueue();
            queueClass.SearchItemsInQueue();

            stackClass.AddElementsInStack();
            stackClass.ReadItemsFromStack();
            stackClass.RemoveElementsInStack();
            stackClass.SearchItemsInStack();


            sortedSetClass.AddElementsInSortedSet();
            sortedSetClass.ReadItemsFromSortedSet();
            sortedSetClass.RemoveElementsInSortedSet();
            sortedSetClass.SearchItemsInSortedSet();

            sortedDictionaryClass.AddElementsInSortedDictionary();
            sortedDictionaryClass.ReadItemsFromSortedDictionary();
            sortedDictionaryClass.RemoveElementsInSortedDictionary();
            sortedDictionaryClass.SearchItemsInSortedDictionary();


            linkedListClass.CloseLogger();

            Console.ReadLine();
        }
    }
}
