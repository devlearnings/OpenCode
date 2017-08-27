using System;
using Autofac;

namespace UnitTestDemo
{
    public class Program
    {
        private static ContainerBuilder _builder;
        private static IContainer _container;

        static void Main(string[] args)
        {

            //IoC
            _builder = new ContainerBuilder();
            _builder.RegisterType<BrPerson>().As<IBrPerson>();
            _builder.RegisterType<Person>().As<IPerson>();
            _container = _builder.Build();


            if (CheckPersonCanDrive(1))
            {
                Console.WriteLine("Person Can Drive");
            }
            else
            {
                Console.WriteLine("Person Can't Drive");
            }
        }

        public static bool CheckPersonCanDrive(int id)
        {
            var brPerson = _container.Resolve<IBrPerson>();
            bool canDrive = brPerson.CanDrive(id);
            return canDrive;
        }
    }
}
