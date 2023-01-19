using System;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Demo");
            Inheritance I = new Inheritance();
            I.DemoInheritance();

            Console.WriteLine("Constructor Demo");
            Constructor C = new Constructor();
            C.DemoConstructor();

            Console.WriteLine();
            Console.WriteLine("Access Modifiers Demo");
            AccessModifiers am = new AccessModifiers();
            am.AccessModifersDemo();


            Console.WriteLine();
            Console.WriteLine("DataTypes Demo");
            DataTypes d = new DataTypes();
            d.DataTypesDemo();

            Console.WriteLine();
            Console.WriteLine("Operator Demo");
            Operators o = new Operators();
            o.OperatorsDemo();

            Console.WriteLine();
            Console.WriteLine("Operator Demo");
            NullableType n = new NullableType();
            n.NullableTypeDemo();

            Console.WriteLine();
            Console.WriteLine("Arrays Demo");
            Arrays array = new Arrays();
            array.ArrayDemo();

            Console.WriteLine();
            Console.WriteLine("Namespaces Demo");
            Namespaces ns = new Namespaces();
            ns.NamespacesDemo();

            Console.WriteLine();
            Console.WriteLine("String Builder Demo");
            StringBuilderTest sbt = new StringBuilderTest();
            sbt.StringBuilderDemo();

            Console.WriteLine();
            Console.WriteLine("String Conversion Demo");
            StringConversion sc = new StringConversion();
            sc.StringConversionDemo();


            Console.ReadKey();


        }
    }
}
