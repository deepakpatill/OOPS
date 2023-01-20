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
            Console.WriteLine("If else Demo");
            IfelseCSharp ie = new IfelseCSharp();
            ie.IfelseDemo();

            Console.WriteLine();
            Console.WriteLine("Switch Case Demo");
            SwitchCase sw = new SwitchCase();
            sw.SwitchCaseDemo();

            Console.WriteLine();
            Console.WriteLine("Static Class Demo");
            StaticClass.StaticClassDemo();


            Console.WriteLine();
            Console.WriteLine("Class Property Demo");
            ClassProperty cp = new ClassProperty();
            cp.ClassPropertyDemo();

            Console.WriteLine();
            Console.WriteLine("String Conversion Demo");
            StringConversion sc = new StringConversion();
            sc.StringConversionDemo();

            Console.WriteLine();
            Console.WriteLine("Struct Demo");
            StructCSharp s1 = new StructCSharp();
            s1.StructDemo();

            Console.WriteLine();
            Console.WriteLine("Abstract Class Demo");
            AbstractCSharp abs = new AbstractCSharp();
            abs.AbstractDemo();


            Console.WriteLine();
            Console.WriteLine("Partial Class Demo");
            PartialClass pc = new PartialClass();
            pc.PartialClassDemo();

            Console.WriteLine();
            Console.WriteLine("While loop demo");
            WhileLoop wl = new WhileLoop();
            wl.WhileLoopDemo();

            Console.WriteLine();
            Console.WriteLine("While loop demo");
            DoWhile dw = new DoWhile();
            dw.DoWhileDemo();

            Console.WriteLine();
            Console.WriteLine("For and ForEach Demo");
            ForLoop fl = new ForLoop();
            fl.ForLoopDemo();

            Console.WriteLine();
            Console.WriteLine("Exception handling demo");
            ExceptionHandling eh = new ExceptionHandling();
            eh.ExceptionHandlingDemmo();

            Console.WriteLine();
            Console.WriteLine("Inner Exception demo");
            InnerException iex = new InnerException();
            iex.InnerExceptionDemo();

            Console.WriteLine();
            Console.WriteLine("Custom Exception Demo");
            CustomException ce = new CustomException();
            ce.CustomExceptionDemo();

            Console.WriteLine();
            Console.WriteLine("Method Hiding Demo");
            MethodHiding mh = new MethodHiding();
            mh.MethodHidingDemo();

            Console.WriteLine();
            Console.WriteLine("Partial Method Demo");
            PartialClass pc1 = new PartialClass();
            pc1.PartialMethodDemo();

            Console.WriteLine();
            Console.WriteLine("Optional Parameters Demo");
            OptionalParams op = new OptionalParams();
            op.OptionalParametersDemo();

            Console.WriteLine();
            Console.WriteLine("Async and await Demo");
            Async a = new Async();
            a.AsyncDemo();

            Console.WriteLine();
            Console.WriteLine("Enum Demo");
            Enum e = new Enum();
            e.EnumDemo();

            


            Console.WriteLine();
            Console.WriteLine("Exception Types Demo");
            ExceptionTypes et = new ExceptionTypes();
            et.ExceptionTypesDemo();

            Console.WriteLine();
            Console.WriteLine("Exception Handling Abuse Demo");
            ExceptionHandlingAbuse eha = new ExceptionHandlingAbuse();
            eha.ExceptionHandlingAbuseDemo();



            Console.ReadKey();


        }
    }
}
