using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\INPUT.TXT";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }





            //string writePath = @"D:\OUTPUT.TXT";

            //int a = 5;
            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            //    {
            //        sw.WriteLine(a);
            //    }
            //    Console.WriteLine("Запись выполнена");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
