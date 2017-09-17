using System;

namespace VegardNet.CSharpForJavaDevelopers.Methods
{
    class MethodsRef
    {
        public static void ValueTypeMethodWithoutRef(int nonRefValue)
        {
            nonRefValue = 6;
            Console.WriteLine("Value in method body: " + nonRefValue);
        }

        public static void ValueTypeMethodWithRef(ref int refValue)
        {
            refValue = 6;
            Console.WriteLine("Value in method body: " + refValue);
        }

        public static void ReferenceTypeMethodThatChangeMemberValue(ReferenceType nonRefValue)
        {
            nonRefValue.value = 6;
            Console.WriteLine("Value in method body: " + nonRefValue.value);
        }

        public static void ReferenceTypeMethodWithoutRef(ReferenceType nonRefValue)
        {
            nonRefValue = new ReferenceType(6);
            Console.WriteLine("Value in method body: " + nonRefValue.value);
        }

        public static void ReferenceTypeMethodWithRef(ref ReferenceType refValue)
        {
            refValue = new ReferenceType(6);
            Console.WriteLine("Value in method body: " + refValue.value);
        }

        public static void Main(string[] args)
        {
            int nonRefValue = 5;
            Console.WriteLine("nonRefValue before method call: " + nonRefValue);
            ValueTypeMethodWithoutRef(nonRefValue);
            Console.WriteLine("nonRefValue after method call (can't be modified, should be 5): " + nonRefValue);

            int refValue = 5;
            Console.WriteLine("\nrefValue before method call: " + refValue);
            ValueTypeMethodWithRef(ref refValue);
            Console.WriteLine("refValue after method call (can be modified, should be 6): " + refValue);

            ReferenceType nonRefReferenceTypeWithModifiedMemberValue = new ReferenceType(5);
            Console.WriteLine("\nnonRefReferenceTypeWithModifiedMemberValue before method call: " + nonRefReferenceTypeWithModifiedMemberValue.value);
            ReferenceTypeMethodThatChangeMemberValue(nonRefReferenceTypeWithModifiedMemberValue);
            Console.WriteLine("nonRefReferenceTypeWithModifiedMemberValue after method call (modified member value, should be 6): " + nonRefReferenceTypeWithModifiedMemberValue.value);

            ReferenceType nonRefReferenceType = new ReferenceType(5);
            Console.WriteLine("\nnonRefReferenceType before method call: " + nonRefReferenceType.value);
            ReferenceTypeMethodWithoutRef(nonRefReferenceType);
            Console.WriteLine("nonRefReferenceType after method call (can't be modified, should be 5): " + nonRefReferenceType.value);

            ReferenceType refReferenceType = new ReferenceType(5);
            Console.WriteLine("\nrefReferenceType before method call: " + refReferenceType.value);
            ReferenceTypeMethodWithRef(ref refReferenceType);
            Console.WriteLine("refReferenceType after method call (can be modified, should be 6): " + refReferenceType.value);

            Console.ReadKey();
        }
    }

    class ReferenceType
    {
        public ReferenceType(int value)
        {
            this.value = value;
        }

        public int value;
    }
}
