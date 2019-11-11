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
                    //Char[] buffer = new char[5];
                    //int a  = sr.Peek();
                    //foreach (var item in buffer)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    //Console.WriteLine(a);

                    int input;
                    bool isValid = int.TryParse(sr.ReadLine(), out input);

                    if (isValid)
                    {
                        Console.WriteLine(input);
  
                    }
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
