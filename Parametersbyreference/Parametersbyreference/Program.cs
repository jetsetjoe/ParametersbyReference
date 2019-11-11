using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametersbyreference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Illustrates the difference between passing parameters by value and passing by referrence

            //declare variables
            int testValue = 1;

            Console.WriteLine("In Main - Original Value: {0}", testValue);

            //call the default method
            TestDefault(testValue);

            //Display test value after calling the default method

            Console.WriteLine("\n Upon return from TestDefault method - Value {0}", testValue);

            Console.WriteLine("\n In Main Original Value: {0}", testValue); 

            //call the testRef method pass para by referrence

            TestRef(ref testValue);

            //Display test Value after calling the test Ref method
            Console.WriteLine("Upon return from testRef method value: {0}", testValue);

            //reset test value back to 1
            testValue = 1;

            Console.WriteLine("\n from main original Value: {0}", testValue);

            //call testOut Method
            TestOut(out testValue);
            //Display testvalue after calling testout method

            Console.WriteLine("Upon return from testOut method value: {0}", testValue);





            Console.ReadKey();
















        }//end of main

        public static void TestRef(ref int aValue)
        {

            //tests the ref keyword - passing parameter by referrence

            aValue = 333;
            Console.WriteLine("Inside TestRef- Value: {0}", aValue);
        }

        public static void TestDefault(int aValue)
        {
            //Default methoed passes parameters by value
            aValue = 111;
            Console.WriteLine(" Inside TestDefault = Value {0}", aValue);
        }

        public static void TestOut(out int aValue)
        {
            //tests the out keyword, passing para by referrence
            aValue = 222;
            Console.WriteLine(" Inside TestOut- Value {0}", aValue); 

        }




    }//end of class
}//end of namespace
