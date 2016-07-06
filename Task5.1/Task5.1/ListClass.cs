﻿using System;
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

        public void AddElementsInList()
        {
            beforeStartMethod = Environment.TickCount;
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            afterStartMethod = Environment.TickCount;
            resultTime = afterStartMethod - beforeStartMethod;
           
            logger.Log("list.Add elements. " + resultTime+"ms");
        }

        public void RemoveElementsInList()
        {
            beforeStartMethod = Environment.TickCount;
            list.RemoveAt(3);
            list.RemoveAt(2);
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
               int temp= list[i];
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
           
            logger.Log("list.Search element. " + resultTime + "ms"+"\n");
        }

        public void CloseLogger()
        {
            logger.Close();
        }
    }
}
