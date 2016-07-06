using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class SortedDictionaryClass
    {
        SortedDictionary<int,int> sortedDictionary = new SortedDictionary<int,int>();
        private Logger logger = Logger.GetLogger();

        int beforeStartMethod;
        int afterStartMethod;
        int resultTime;

        public void AddElementsInSortedDictionary()
        {
            beforeStartMethod = Environment.TickCount;
            sortedDictionary.Add(1,1);
            sortedDictionary.Add(2,2);
            sortedDictionary.Add(3,3);
            sortedDictionary.Add(4,4);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("SortedDictionary.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInSortedDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            sortedDictionary.Remove(4);
            sortedDictionary.Remove(3);
            sortedDictionary.Remove(1);

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

            logger.Log("SortedDictionary.Search element. " + resultTime + "ms"+"\n");
        }
    }
}
