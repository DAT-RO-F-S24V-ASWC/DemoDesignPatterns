using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Comments
{
    /// <summary>
    /// Dette er en fjollet klasse
    /// </summary>
    public class CommentWorker
    {

        /// <summary>
        /// Denne metoder er lidt sjov ganger x med n
        /// </summary>
        /// <param name="x">Et heltal der skal ganges</param>
        /// <param name="n">En string hvor kun '2' og '3' er lovlige</param>
        /// <returns>værdien x ganget med 2 hhv 3 afh af n</returns>
        /// <exception cref="ArgumentNullException">HVis der ikke er en værdi i strengen n</exception>
        /// <exception cref="ArgumentException">værdien i n er ikke 2 eller 3</exception>
        /// <exception cref="NotImplementedException">Dummy</exception>
        public int SomeSillyMethod(int x, String n)
        {
            if (string.IsNullOrWhiteSpace(n)) throw new ArgumentNullException("n must have a value but was null or empty");
            if (!(n == "2" || n == "3")) throw new ArgumentException("Only '2' or '3' is supported but was " + n);
            switch (n)
            {
                case "2": return x * 2;
                case "3": return x * 3;
            }
            throw new NotImplementedException("");
        }
    }
}
