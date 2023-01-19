using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class InnerException
    {
        public void InnerExceptionDemo()
        {
            try
            {
                try
                {
                    int a = Convert.ToInt32("Text");
                }
                catch (Exception e)
                {
                    string file = @"C:\log.text";
                    if (File.Exists(file))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(e.Message);
                        StreamWriter sw = new StreamWriter(file);
                        sw.Write(sb.ToString());
                        sw.Close();
                        Console.WriteLine("There's a prblem, Please try again later");
                    }
                    else
                    {
                        string Message = " file does not exist";
                        throw new FileNotFoundException(Message, e);
                    }
                }
            }
            catch(Exception ex)
            {
                if(ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: {0}", ex.Message);
                }
            }
        }
    }
}
