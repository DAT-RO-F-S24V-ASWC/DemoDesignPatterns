using DemoDesignPatterns.TemplatePettern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns
{
    public class DesignWorkerTemplate
    {
        
        public void Start()
        {
            List<String> data = new List<string>()
            {
                "Peter",
                "Anders",
                "Vibeke",
                "Michael C"
            };

            AbstractTemplateClass temp = new MySubTemplate();
            temp.InsertTemplateMethod(data);


            //todo lav noget
            Console.WriteLine(temp);

        }
    }
}
