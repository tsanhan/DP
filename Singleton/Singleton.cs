using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class Singleton
    {
        //1. must be public
        //2. deny creating more then 1 instance of the class
        //3. make sure this one instance is the same instance
        //4. make the singleton thread safe

        private Singleton()
        {
            // ctore code
        }
        private static Singleton instance;
        private static readonly object key = new object();
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (key)// ...500
                {
                    if (instance == null)//true, false, false, false
                        instance = new Singleton();
                }
            }
            return instance;
        }

        public void doWork()
        {
            // db, connections, all the examples
        }


    }
}
