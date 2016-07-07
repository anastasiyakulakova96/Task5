using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class CollectionsTimeTest
    {
        List<Collectionable> collections = new List<Collectionable>();
        Stopwatch stopwatch = new Stopwatch();
        private Logger logger = Logger.GetLogger();

       public void AddCollections()
        {
            collections.Add(new ListClass());
            collections.Add(new DictionaryClass());
            collections.Add(new LinkedListClass());
            collections.Add(new QueueClass());
            collections.Add(new SortedDictionaryClass());
            collections.Add(new SortedSetClass());
            collections.Add(new StackClass());
        }

        public void TimeTestForAdd()
        {
            logger.Log("Add elements:");
            foreach (Collectionable c in collections)
            {
                stopwatch.Start();
                c.AddElements();
                stopwatch.Stop();
                logger.Log(c.GetType().Name + " " + stopwatch.ElapsedMilliseconds + "ms");
                stopwatch.Reset();
            }
            logger.Log(" ");
        }

        public void TimeTestForRemove()
        {
            logger.Log("Remove elements:");
            foreach (Collectionable c in collections)
            {
                stopwatch.Start();
                c.RemoveElements();
                stopwatch.Stop();
                logger.Log(c.GetType().Name + " " + stopwatch.ElapsedMilliseconds + "ms");
                stopwatch.Reset();
            }
            logger.Log(" ");
        }

        public void TimeTestForGet()
        {
            logger.Log("Get elements:");
            foreach (Collectionable c in collections)
            {
                stopwatch.Start();
                c.GetElements();
                stopwatch.Stop();
                logger.Log(c.GetType().Name + " " + stopwatch.ElapsedMilliseconds + "ms");
                stopwatch.Reset();
            }
            logger.Log(" ");
        }

        public void TimeTestForSearch()
        {
            logger.Log("Search elements:");
            foreach (Collectionable c in collections)
            {
                stopwatch.Start();
                c.SearchElement();
                stopwatch.Stop();
                logger.Log(c.GetType().Name + " " + stopwatch.ElapsedMilliseconds + "ms");
                stopwatch.Reset();
            }
        }
    }
}
