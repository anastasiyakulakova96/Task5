using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class LinkedListClass : Collectionable
    {
        LinkedList<int> linkedList = new LinkedList<int>();
       
        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                linkedList.AddFirst(i);
            }
        }


        public void RemoveElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                linkedList.Remove(i);
            }
        }


        public void GetElements()
        {
            foreach (int s in linkedList)
            {
                int a = s;
            }
        }


        public void SearchElement()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                bool temp = linkedList.Contains(i);
            }
        }

    }
}
