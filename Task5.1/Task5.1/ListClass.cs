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

        int beforeStartMethod;
        int afterStartMethod;

        public void AddElementsInList()
        {
            beforeStartMethod = Environment.TickCount;
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(4);
            list.Add(4);
            list.Add(4);
            list.Add(4);
            list.Add(4);
            list.Add(4);
            RemoveElementsInList();
            afterStartMethod =Environment.TickCount;
            
            int resultTime = afterStartMethod - beforeStartMethod;
            Console.WriteLine("beforeStartMethod"+ beforeStartMethod);
            Console.WriteLine("afterStartMethod"+ afterStartMethod);
            Console.WriteLine("  result   "+ resultTime);
        }

        public void RemoveElementsInList()
        {
            list.RemoveAt(0);
            list.RemoveAt(2);
            list.RemoveAt(3);
        }

        
        
    }
}
