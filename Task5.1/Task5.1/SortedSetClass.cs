using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class SortedSetClass : Collectionable
    {
        SortedSet<int> sortedSet = new SortedSet<int>();

        private Logger logger = Logger.GetLogger();

        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                sortedSet.Add(i);
            }
        }


        public void RemoveElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                sortedSet.Remove(i);
            }
        }


        public void GetElements()
        {
            foreach (int s in sortedSet)
            {
                int a = s;
            }
        }


        public void SearchElement()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                bool temp = sortedSet.Contains(i);
            }
        }
    }
}
