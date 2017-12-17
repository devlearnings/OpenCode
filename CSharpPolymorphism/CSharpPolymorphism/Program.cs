using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //With Virtual & Override
            Console.WriteLine("With Virtual & Override\n");
            Parent p1 = new Parent();
            p1.DoSomething();

            Child c1 = new Child();
            c1.DoSomething();

            Parent p2 = new Child();
            p2.DoSomething();

            Console.WriteLine("\n------------------------------\n");

            //Without  Virtual & Override
            Console.WriteLine("Without Virtual & Override\n");
            Parent p3 = new Parent();
            p3.DoSomethingSame();

            Child c2 = new Child();
            c2.DoSomethingSame();

            Parent p4 = new Child();
            p4.DoSomethingSame();


            //Incorrect object creation
            //Child c3 = new Parent();


            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\nOver loading\n");
            Console.WriteLine("------------------------------\n");

            Overloading oObj = new Overloading();
            oObj.Add(5, 10);

            Console.ReadKey();
        }
    }

    public class Parent
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("Inside Parent : DoSomething");
        }

        public void DoSomethingSame()
        {
            Console.WriteLine("Inside Parent : DoSomethingSame");
        }
    }

    public class Child : Parent
    {
        public override void DoSomething()
        {
            Console.WriteLine("Inside Child : DoSomething");
        }

        public new void DoSomethingSame()
        {
            Console.WriteLine("Inside Child : DoSomethingSame");
        }
    }

    public class Overloading
    {
        //Base Method
        public int Add(int a, int b)
        {
            return a + b;
        }

        //Possible over loads
        public int Add(int a, int b, int c = 0)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        //Compiler error

        //Below methods will give comile time AMBIGUITY error if method is called like. 
        //Such methods will not give any compile error if they are not called from any where;

        //oObj.Add(5, 10);
        //public double Add(int a, double b)
        //{
        //    return a + b;
        //}

        //public double Add(double a, int b)
        //{
        //    return a + b;
        //}


        //oObj.Add(5);
        //public int Add(int a, int b = 0, int c = 0)
        //{
        //    return a + 1 + 2;
        //}

        //public int Add(int a , int b = 0)
        //{
        //    return a + 1;
        //}


        //Same signature
        //public double Add(int a, int b)
        //{
        //    return a + b;
        //}
    }

}
