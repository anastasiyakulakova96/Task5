using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class StackClass
    {
        Stack<int> stack = new Stack<int>();
        private Logger logger = Logger.GetLogger();

        int beforeStartMethod;
        int afterStartMethod;
        int resultTime;
        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElementsInStack()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                stack.Push(i);
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Stack.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInStack()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                stack.Pop();
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Stack.Remove elements. " + resultTime + "ms");
        }

        public void ReadItemsFromStack()
        {
            beforeStartMethod = Environment.TickCount;

            foreach (int s in stack)
            {
                int a = s;
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Stack.Read elements. " + resultTime + "ms");
        }

        public void SearchItemsInStack()
        {
            beforeStartMethod = Environment.TickCount;

            bool temp = stack.Contains(1);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Stack.Search element. " + resultTime + "ms" + "\n");
        }
    }
}
