using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class DictionaryClass : Collectionable
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                dictionary.Add(i, i);
            }
        }

        public void RemoveElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                dictionary.Remove(i);
            }
        }

        public void GetElements()
        {
            foreach (int s in dictionary.Keys)
            {
                int a = s;
            }
        }

        public void SearchElement()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                bool temp = dictionary.ContainsKey(i);
            }
        }
    }
}
