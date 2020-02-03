using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ElsoFajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> szoveglista = new List<string>();

            using (StreamReader sr = new StreamReader("proba.txt", Encoding.UTF8))
            {
                
                while (!sr.EndOfStream)
                {
                    string beiras = sr.ReadLine();
                    szoveglista.Add(beiras);
                }
            }

            for (int i = 0; i < szoveglista.Count; i++)
            {
                Console.WriteLine(szoveglista[i]);
            }

            using (StreamWriter sw = new StreamWriter("proba.txt", true, Encoding.UTF8))
            {
                string beir = "Ez itt a harmadik sor.";
                sw.WriteLine(beir);
            }

                //Console.WriteLine(szoveg);

                Console.ReadKey(true);

        }
    }
}
