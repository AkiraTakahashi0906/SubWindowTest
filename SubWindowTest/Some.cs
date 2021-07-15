using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubWindowTest
{
    public class Some
    {
        protected static Some instance;
        static Some()
        {
            instance = new Some();
        }
        static public Some getInstance()
        {
            return instance;
        }

        public string Name { get; set; }

        virtual public void Print()
        {
            Console.WriteLine("Some");
        }
    }

    internal class SomeDummy : Some
    {
        internal static void UseDummy()
        {
            instance = new SomeDummy();
        }
        public override void Print()
        {
            Console.WriteLine("Dummy");
        }
    }

}
