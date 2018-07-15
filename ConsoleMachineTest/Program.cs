using System;
using System.Linq;

namespace ConsoleMachineTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var operation = args[0];
            var values = string.Empty;

            if (args.Length > 1)
                values = args[1];

            var result = 0;

            var delimeter = GetDelimeter(values);
            var inputValues = GetInputValue(values);

            if (inputValues.Contains("Error"))
            {
                Console.WriteLine(inputValues);
                Console.ReadKey();
                return;
            }

            switch (operation)
            {
                case "sum":
                case "add":
                    result = Sum(delimeter, inputValues);
                    break;
                case "multiply":
                    result = Multiply(delimeter, inputValues);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static char[] GetDelimeter(string values)
        {
            char[] delimeter = { ',', '\n' };

            if (values.IndexOf("\\", StringComparison.Ordinal) == 0)
            {
                delimeter = values.Split('\\')[1].ToCharArray();
            }

            return delimeter;
        }

        public static string GetInputValue(string values)
        {
            if (values.IndexOf("\\", StringComparison.Ordinal) == 0)
            {
                values = values.Split('\\')[2];
            }

            if (values.Contains("-"))
            {
                string negativeValues = string.Empty;

                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] == '-')
                        negativeValues += "-" + values[i + 1] + ",";
                }

                negativeValues = negativeValues.TrimEnd(',');

                values = "Error: Negative numbers (" + negativeValues + ") not allowed.";
            }

            return values;
        }

        public static int Sum(char[] delimeter, string values)
        {
            var valuesArray = values.Split(delimeter);

            var result = 0;

            var e = valuesArray.GetEnumerator();
            while (e.MoveNext())
            {
                if (e.Current != null && Int32.TryParse(e.Current.ToString(), out int currValue))
                {
                    if (currValue < 1000)
                        result += currValue;
                }
            }

            return result;
        }

        public static int Multiply(char[] delimeter, string values)
        {
            var valuesArray = values.Split(delimeter);

            var result = 1;

            var e = valuesArray.GetEnumerator();
            while (e.MoveNext())
            {
                if (e.Current != null && Int32.TryParse(e.Current.ToString(), out int currValue))
                {
                    if (currValue < 1000)
                        result *= currValue;
                }
            }

            return result;
        }


    }
}
