using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class QueueClass
    {
        Queue<int> queue = new Queue<int>();

        private Logger logger = Logger.GetLogger();

        int beforeStartMethod;
        int afterStartMethod;
        int resultTime;
        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElementsInQueue()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                queue.Enqueue(i);
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Queue.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInQueue()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < queue.Count; i++)
            {
                queue.Dequeue();
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Queue.Remove elements. " + resultTime + "ms");
        }

        public void ReadItemsFromQueue()
        {
            beforeStartMethod = Environment.TickCount;

            foreach (int s in queue)
            {
                int a = s;
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Queue.Read elements. " + resultTime + "ms");
        }

        public void SearchItemsInQueue()
        {
            beforeStartMethod = Environment.TickCount;

            bool temp = queue.Contains(1);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Queue.Search element. " + resultTime + "ms" + "\n");
        }

    }
}
