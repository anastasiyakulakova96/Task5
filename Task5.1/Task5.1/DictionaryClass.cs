using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class DictionaryClass
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        private Logger logger = Logger.GetLogger();

        int beforeStartMethod;
        int afterStartMethod;
        int resultTime;
        int countOfElements = Int32.Parse(Data.countOfElements);

        public void AddElementsInDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                dictionary.Add(i, i);
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Dictionary.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            for (int i = 0; i < countOfElements; i++)
            {
                dictionary.Remove(i);
            }

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Dictionary.Remove elements. " + resultTime + "ms");
        }

        public void ReadItemsFromDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            foreach (int s in dictionary.Keys)
            {
                int a = s;
            }
            foreach (int s in dictionary.Values)
            {
                int a = s;
            }
            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Dictionary.Read elements. " + resultTime + "ms");
        }

        public void SearchItemsInDictionaryt()
        {
            beforeStartMethod = Environment.TickCount;

            bool temp = dictionary.ContainsKey(1);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;

            logger.Log("Dictionary.Search element. " + resultTime + "ms" + "\n");
        }

    }
}
