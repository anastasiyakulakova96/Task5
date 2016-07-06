using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class SortedSetClass
    {
        SortedSet<int> sortedSet = new SortedSet<int>();

        private Logger logger = Logger.GetLogger();

        int beforeStartMethod;
        int afterStartMethod;
        int resultTime;

        public void AddElementsInSortedSet()
        {
            beforeStartMethod = Environment.TickCount;
            sortedSet.Add(1);
            sortedSet.Add(2);
            sortedSet.Add(3);
            sortedSet.Add(4);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("SortedSet.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInSortedSet()
        {
            beforeStartMethod = Environment.TickCount;

            sortedSet.Remove(4);
            sortedSet.Remove(3);
            sortedSet.Remove(1);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("SortedSet.Remove elements. " + resultTime + "ms");
        }

        public void ReadItemsFromSortedSet()
        {
            beforeStartMethod = Environment.TickCount;

            foreach (int s in sortedSet)
            {
                int a = s;
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("SortedSet.Read elements. " + resultTime + "ms");
        }

        public void SearchItemsInSortedSet()
        {
            beforeStartMethod = Environment.TickCount;

            bool temp = sortedSet.Contains(1);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("SortedSet.Search element. " + resultTime + "ms"+"\n");
        }
    }
}
