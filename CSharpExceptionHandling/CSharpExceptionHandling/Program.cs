using System;

namespace CSharpExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }

        static void DoSomething()
        {
            try
            {
                Console.WriteLine("Inside try block");

                throw new NullReferenceException();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside catch block");

                //throw(ex) will reset your stack trace so error will appear from the line where throw(ex) written while 
                //throw does not reset stack trace and you will get information about original exception.
                //throw ex;

                //it’s always best practice to use throw instead of throw (ex).
                throw;

            }
            finally
            {
                Console.WriteLine("Inside finally block");
            }
        }
    }
}
