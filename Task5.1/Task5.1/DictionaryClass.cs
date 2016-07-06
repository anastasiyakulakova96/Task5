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

        public void AddElementsInDictionary()
        {
            beforeStartMethod = Environment.TickCount;
            dictionary.Add(1,1);
            dictionary.Add(2, 2);
            dictionary.Add(3, 3);
            dictionary.Add(4, 4);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;
          
            logger.Log("Dictionary.Add elements. " + resultTime + "ms");
        }

        public void RemoveElementsInDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            dictionary.Remove(4);
            dictionary.Remove(2);
            dictionary.Remove(1);
            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;
            
            logger.Log("Dictionary.Remove elements. " + resultTime + "ms");
        }

        public void ReadItemsFromDictionary()
        {
            beforeStartMethod = Environment.TickCount;

            foreach ( int s in dictionary.Keys)
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

            logger.Log("Dictionary.Search element. " + resultTime + "ms"+"\n");
        }

    }
}
