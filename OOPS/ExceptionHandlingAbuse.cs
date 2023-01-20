using System;

namespace OOPS
{
    class ExceptionHandlingAbuse
    {

        public void ExceptionHandlingAbuseDemo()
        {
            try
            {
                Console.WriteLine("Please enter First Number");
                int Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Second Number");
                int Num2 = Convert.ToInt32(Console.ReadLine());
                int Result = Num1 / Num2;
                Console.WriteLine("Result = {0}", Result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only numbers between {0} & {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Second Number cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
