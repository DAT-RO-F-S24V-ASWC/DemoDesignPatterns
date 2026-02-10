using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns
{
    public class MyLogger
    {
        /* Singleton 3 trin */
        // trin et - constructor private
        private MyLogger()
        {
            
        }
        // trin 2 - lav et objekt - husk static
        private static MyLogger _instance = new MyLogger();

        // trin 3 - lav public get metode - static
        public static MyLogger Instance
        {
            get { return _instance; }
        }
        /*
         * Singleton slut
         */

        public int Tal { get; set; }
    }
}
