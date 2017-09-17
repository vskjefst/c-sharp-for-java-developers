package net.vegard.csharpforjavadevs.methods;

public class MethodsPassByValue {
    public static void primitiveTypeParameter(int value) {
        value = 6;
        System.out.println("Value in method body: " + value);
    }

    public static void referenceTypeParameter(ReferenceType referenceType) {
        referenceType = new ReferenceType(6);
        System.out.println("Value in method body: " + referenceType.value);
    }

    public static void referenceTypeParameterChangeMemberValue(ReferenceType referenceType) {
        referenceType.value = 6;
        System.out.println("Value in method body: " + referenceType.value);
    }

    public static void main(final String[] args) {
        int value = 5;
        System.out.println("Value before method call: " + value);
        primitiveTypeParameter(5);
        System.out.println("Value after method call (can't be changed, should be 5): " + value);

        ReferenceType referenceType = new ReferenceType(5);
        System.out.println("\nValue before method call: " + referenceType.value);
        referenceTypeParameter(referenceType);
        System.out.println("Value after method call (can't be changed, should be 5): " + referenceType.value);

        ReferenceType referenceTypeChangeMemberValue = new ReferenceType(5);
        System.out.println("\nValue before method call: " + referenceTypeChangeMemberValue.value);
        referenceTypeParameterChangeMemberValue(referenceTypeChangeMemberValue);
        System.out.println("Value after method call (modified member value, should be 6): " + referenceTypeChangeMemberValue.value);
    }

    private static class ReferenceType {
        public int value;

        public ReferenceType(int value) {
            this.value = value;
        }
    }
}