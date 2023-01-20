using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class OutofMemory
    {
        public void Test()
        {
           try
            {
                string a = new string('r', int.MaxValue);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class NullReference  
    {
        public void Test()
        {
            try
            {
                string a = null;
                if (a.Length == 0)
                {
                    Console.WriteLine(a);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class InvalidCast
    {
        public void Test()
        {
            try
            {
                int i = 0;
                object obj = i;
                int num = (short)obj;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
            }
        }
    }
    public class DivideByZero
    {
        public void Test()
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;
                Console.WriteLine("c: {0}", c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class IndexOutOfRange
    {
        public void Test()
        {
            try
            {
                int[] arr = new int[3] { 1, 2, 3 };
                Console.WriteLine(arr[3]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class ArrayTypeMismatch
    {
        public void Test()
        {
            try
            {
                string[] arr = new string[3] { "A","B","C" };
                object[] arr1 = arr;
                arr1[1] = 5;
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class FileNotFound
    {
        public void Test()
        {
            var filename = "log.txt";
            try
            {
                var content = File.ReadAllText(filename);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class StackOverflow
    {
        public void Demo(int val)
        {
            //Console.WriteLine(val);
            Demo(++val);
        }
        public void Test()
        {
            try
            {
                Demo(0);
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class ArgumentOutofRange
    {
        public void Test()
        {
            try
            {
                var numlist = new List<int>();
                numlist.RemoveAt(-1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class Argument
    {
        public void Test()
        {
            try
            {
                string id = null;
                int i = int.Parse(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    class ExceptionTypes
    {
        public void ExceptionTypesDemo()
        {
            OutofMemory e1 = new OutofMemory();
            e1.Test();

            Console.WriteLine();
            NullReference e2 = new NullReference();
            e2.Test();

            Console.WriteLine();
            DivideByZero e3 = new DivideByZero();
            e3.Test();

            Console.WriteLine();
            IndexOutOfRange e4 = new IndexOutOfRange();
            e4.Test();

            Console.WriteLine();
            ArrayTypeMismatch e5 = new ArrayTypeMismatch();
            e5.Test();

            Console.WriteLine();
            FileNotFound e6 = new FileNotFound();
            e6.Test();

            Console.WriteLine();
            InvalidCast e7 = new InvalidCast();
            e7.Test();

            Console.WriteLine();
            Argument e8 = new Argument();
            e8.Test();

            Console.WriteLine();    
            ArgumentOutofRange e9 = new ArgumentOutofRange();
            e9.Test();

            StackOverflow e10 = new StackOverflow();
            e10.Test();
        }
    }
}
