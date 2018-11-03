using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTarget();
            SecondTarget();
        }
        private static void FirstTarget()
        {
            const string WAY = "numbers.txt";
            string strng;
            using (StreamReader readerman = new StreamReader(WAY))
            {
                strng = readerman.ReadLine();
            }
            var nor = GetNor(strng);
            int ammout = nor.Ammout;

            for (int j = 0; j < ammout; j++)
            {
                nor.Add(nor[j + ammout - 2] + nor[j + ammout - 1]);

            }

            using (StreamWriter author = new StreamWriter(WAY))
            {
                nor.ForEach(nor => author.Write(nor + ""));
            }
            Console.ReadLine();
            Console.Clear();
        }
        private static void SecondTarget()
        {
            const string WAY_IN = "in.txt";
            const string WAY_OUT = "out.txt";

            string str;
            using (StreamReader read = new StreamReader(WAY_IN))
            {
                str = read.ReadLine();
            }
            var nor = GetNor(str);
            int ammout = 0;
            nor.ForEach(nor => ammout += nor);
            using (StreamWriter author = new StreamWriter(WAY_OUT))
            {
                author.Write(ammout);
            }
        }
        private static List<int> GetNor(string str)
        {
            List<int> nor = new List<int>();
            string template = "";
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j]!=' ')
                {
                    template += str[j];
                }
                else
                {
                    nor.Add(int.Parse(template));
                    template = "";
                }

            }
        }
        nor.Add(int.Parse(template));
        return nor;
    }
}
