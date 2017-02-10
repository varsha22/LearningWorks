using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarningFixTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Derived Derived = new Derived();
                //Console.WriteLine(Derived.x);
                //throw new NotImplementedException();

                ////Warning for obsolete
                //// Generates 2 warnings:
                //A a = new A();
                //// Generate no errors or warnings:
                //B b = new B();
                //b.NewMethod();
                //// Generates an error, terminating compilation:
                //b.OldMethod();
                ////Warning for obsolete
            }
            catch (Exception)
            {
                //throw;
            }
            int x = 0;
            Console.Write(x);
        }
    }
    abstract class Base
    {
        public virtual int x
        {
            get { throw new NotImplementedException(); }
        }
    }
    class Derived : Base
    {
        public override int x
        {
            get
            {
                Console.Write("it works");
                return 1;
            }
        }
    }
    //Warning for obsolete
    [System.Obsolete("use class B")]
    class A
    {
        public void Method() { }
    }
    class B
    {
        [System.Obsolete("use NewMethod", true)]
        public void OldMethod() { }
        public void NewMethod() { }
    }
    //Warning for obsolete
}

