using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class SortedDictionaryClass : Collectionable
    {
        SortedDictionary<int, int> sortedDictionary = new SortedDictionary<int, int>();

        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                sortedDictionary.Add(i, i);
            }
        }


        public void RemoveElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                sortedDictionary.Remove(i);
            }
        }


        public void GetElements()
        {
            foreach (int s in sortedDictionary.Keys)
            {
                int a = s;
            }
        }

        public void SearchElement()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                bool temp = sortedDictionary.ContainsKey(i);
            }
        }
    }
}
