using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDictionary<int, string> Tester = new TestDictionary<int, string>();


            Tester.Add(1, "1");
            Tester.Add(2, "2");
            Tester.Add(3, "3");
            Tester.Add(4, "4");
            Tester.Add(5, "5");

            foreach (TestKeyValuePairs<int, string> item in Tester)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            Console.WriteLine(Tester.FindByKey(1).ToString());

            Console.WriteLine();
            Tester.RemoveByValue("1");

            foreach (TestKeyValuePairs<int, string> item in Tester)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            Tester.RemoveByKey(2);
            Console.WriteLine(Tester.FindByValue("2").ToString());

            Console.ReadLine();
        }
    }
}
