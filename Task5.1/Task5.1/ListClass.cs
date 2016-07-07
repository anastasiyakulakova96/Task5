using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task5._1
{
    class ListClass : Collectionable
    {
        List<int> list = new List<int>();

        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                list.Add(i);
            }
        }


        public void RemoveElements()
        {
            for (int i = countOfElements; i < countOfElements; i--)
            {
                list.RemoveAt(i);
            }
        }


        public void GetElements()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int temp = list[i];
            }
        }


        public void SearchElement()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                bool temp = list.Contains(i);
            }
        }
    }
}
