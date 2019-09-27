using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> lista = new List<int>();
                int max = 0;
                int bekertSzam = 0;
                int bekeresSzam = 0;
                int min = 1000000000;
                Console.WriteLine("Adja meg hány szám közül szeretné megkeresni a legnagyobbat: ");
                bekeresSzam = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < bekeresSzam; i++)
                {
                    bekertSzam = Convert.ToInt16(Console.ReadLine());
                    lista.Add(bekertSzam);
                }
                for (int i = 0; i < lista.Count; i++)
                {
                    if (max < lista[i])
                    {
                        max = lista[i];
                    }

                }
                Console.WriteLine("A legnagyobb szám:{0} ", max);
                for (int i = 0; i < lista.Count; i++)
                {
                    if (min > lista[i])
                    {
                        min = lista[i];
                    }

                }
                Console.WriteLine("A legkisebb szám: {0}", min);
            }
            catch (Exception)
            {
                Console.WriteLine("Kérem csak számot használjon."
                    );
            }
            Console.ReadKey();
        }
    }
}
