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
            // oooo
            string path = @"INPUT.TXT";
            string line;
            string text = null;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    text = text + line;
                }
            }

            string[] numbers = text.Split(new char[] { ' ' });

            int sum = 0;
            foreach (string number in numbers)
            {
                int b = Convert.ToInt32(number);
                sum = sum + b;
            }
            Console.WriteLine(sum);


            string writePath = @"OUTPUT.TXT";

                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(sum);
                }
        }
    }
}
