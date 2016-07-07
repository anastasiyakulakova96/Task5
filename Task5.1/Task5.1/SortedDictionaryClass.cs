using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class SortedDictionaryClass
    {
        SortedDictionary<int, int> sortedDictionary = new SortedDictionary<int, int>();
        private Logger logger = Logger.GetLogger();

        int beforeStartMethod;
        int afterStartMethod;
        int resultTime;
        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElementsInSortedDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                sortedDictionary.Add(i, i);
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("SortedDictionary.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInSortedDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                sortedDictionary.Remove(i);
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("SortedDictionary.Remove elements. " + resultTime + "ms");
        }

        public void ReadItemsFromSortedDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            foreach (int s in sortedDictionary.Keys)
            {
                int a = s;
            }

            foreach (int s in sortedDictionary.Values)
            {
                int a = s;
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;
            logger.Log("SortedDictionary.Read elements. " + resultTime + "ms");
        }

        public void SearchItemsInSortedDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            bool temp = sortedDictionary.ContainsKey(1);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("SortedDictionary.Search element. " + resultTime + "ms" + "\n");
        }
    }
}
