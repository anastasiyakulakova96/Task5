using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class StackClass : Collectionable
    {
        Stack<int> stack = new Stack<int>();

        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                stack.Push(i);
            }
        }


        public void RemoveElements()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                stack.Pop();
            }
        }


        public void GetElements()
        {
            foreach (int s in stack)
            {
                int a = s;
            }
        }


        public void SearchElement()
        {
            for (int i = 0; i < countOfElements; i++)
            {
                bool temp = stack.Contains(1);
            }
        }
    }
}
