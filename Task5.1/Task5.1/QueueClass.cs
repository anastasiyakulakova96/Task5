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

        public void AddElementsInQueue()
        {
            beforeStartMethod = Environment.TickCount;
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Queue.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInQueue()
        {
            beforeStartMethod = Environment.TickCount;

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

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

            logger.Log("Queue.Search element. " + resultTime + "ms"+"\n");
        }

    }
}
