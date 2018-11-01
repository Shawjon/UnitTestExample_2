using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample_2
{
    public class ReturnArray
    {
        public string PrintVar { get; set; }
        public ReturnArray()
        {
        }

        public static void ConsolePrintToScreen()
        {
            ReturnArray test = new ReturnArray();
            Console.WriteLine(test.PrintVar);
        }
        public int[] ReturnSameArray(int[] array)
        {
            return array;
        }
      

        public bool CheckEven(int[] intArray)
        {
            foreach (var element in intArray)
            {
                if ((element % 2) != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
