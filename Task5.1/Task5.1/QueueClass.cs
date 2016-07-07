using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class QueueClass : Collectionable
    {
        Queue<int> queue = new Queue<int>();

        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                queue.Enqueue(i);
            }
        }


        public void RemoveElements()
        {
            for (int i = 0; i < queue.Count; i++)
            {
                queue.Dequeue();
            }
        }


        public void GetElements()
        {
            foreach (int s in queue)
            {
                int a = s;
            }
        }


        public void SearchElement()
        {

            for (int i = 0; i < queue.Count; i++)
            {
                bool temp = queue.Contains(i);
            }
        }
    }
}
