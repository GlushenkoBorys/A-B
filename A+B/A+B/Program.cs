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
                    //int [] my = new int [5];
                    //int len = 5;
                    //for (int i = 0; i < len; i++)
                    //{
                    //    my[i] = sr.Peek();
                    //    Console.WriteLine(my[i]);
                    //}

                    //Console.WriteLine(my);
                    //bool n;
                    //string b;
                    //n = sr.ReadLine() is string;
                    //b = sr.ReadToEnd();
                    //Console.WriteLine(n);
                    //Console.WriteLine(b);
                    string my = sr.ReadLine().ToString();

                    //string text = sr.ReadLine();
                    //string[] words = my.Split(new char[] { ' ' });

                    //foreach (string s in words)
                    //{
                    //    Console.WriteLine(s);
                    //}
                    string text = "2 3";

                    string[] words = my.Split(new char[] { ' ' });

                    int d = 0;
                    foreach (string s in words)
                    {                        
                        int b = Convert.ToInt32(s);
                        d = d + b;
                    }
                    Console.WriteLine(d);

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
