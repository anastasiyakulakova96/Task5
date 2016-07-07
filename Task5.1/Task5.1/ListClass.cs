using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task5._1
{
    class ListClass
    {
        List<int> list = new List<int>();
        private Logger logger = Logger.GetLogger();

        int beforeStartMethod;
        int afterStartMethod;
        int resultTime;
        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElementsInList()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                list.Add(i);
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("list.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInList()
        {
            beforeStartMethod = Environment.TickCount;


            list.RemoveAt(0);
        afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("list.Remove elements. " + resultTime + "ms");
        }

        public void ReadItemsFromList()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < list.Count; i++)
            {
                int temp = list[i];
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("list.Read elements. " + resultTime + "ms");
        }

        public void SearchItemsInList()
        {
            beforeStartMethod = Environment.TickCount;

            bool temp = list.Contains(1);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("list.Search element. " + resultTime + "ms" + "\n");
        }

        public void CloseLogger()
        {
            logger.Close();
        }
    }
}
