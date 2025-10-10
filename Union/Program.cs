namespace Union
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    struct MyUnion
    {
        [FieldOffset(0)]
        public int intValue;

        [FieldOffset(0)]
        public float floatValue;

        [FieldOffset(0)]
        public char charValue;
    }

    class Program
    {
        static void Main()
        {

            MyUnion myUnion;

            myUnion.intValue = 42;
            Console.WriteLine("Integer value: " + myUnion.intValue);

            myUnion.floatValue = 3.14f;
            Console.WriteLine("Float value: " + myUnion.floatValue);

            myUnion.charValue = 'A';
            Console.WriteLine("Char value: " + myUnion.charValue);

            Console.ReadKey();

        }
    }

}