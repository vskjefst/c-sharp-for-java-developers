using System;

namespace VegardNetCSharpForJavaDevelopers.Methods
{
    class MethodsRef
    {
        public static void MethodWithoutRef(int nonRefValue)
        {
            nonRefValue++;
        }

        public static void MethodWithRef(ref int refValue)
        {
            refValue++;
        }

        public static void Main(string[] args)
        {
            int nonRefValue = 5;
            Console.WriteLine("nonRefValue before method call: " + nonRefValue);
            MethodWithoutRef(nonRefValue);
            Console.WriteLine("nonRefValue after method call: " + nonRefValue);

            int refValue = 5;
            Console.WriteLine("refValue before method call: " + refValue);
            MethodWithRef(ref refValue);
            Console.WriteLine("refValue after method call: " + refValue);

            Console.ReadKey();
        }
    }
}
