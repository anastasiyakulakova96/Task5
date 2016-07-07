using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class LinkedListClass
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        private Logger logger = Logger.GetLogger();

        int beforeStartMethod;
        int afterStartMethod;
        int resultTime;
        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElementsInLinkedList()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                linkedList.AddFirst(i);
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("LinkedList.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInLinkedList()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                linkedList.Remove(i);
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("LinkedList.Remove elements. " + resultTime + "ms");
        }

        public void ReadItemsFromLinkedList()
        {
            beforeStartMethod = Environment.TickCount;

            foreach (int s in linkedList)
            {
                int a = s;
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("LinkedList.Read elements. " + resultTime + "ms");
        }

        public void SearchItemsInLinkedList()
        {
            beforeStartMethod = Environment.TickCount;

            bool temp = linkedList.Contains(1);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("LinkedList.Search element. " + resultTime + "ms" + "\n");
        }

        public void CloseLogger()
        {
            logger.Close();
        }
    }
}
