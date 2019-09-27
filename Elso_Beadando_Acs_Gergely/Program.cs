using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elso_Beadando_Acs_Gergely
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            int max = 0;
            int bekertSzam = 0;
            int bekeresSzam = 0;
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
            Console.ReadKey();
        }
    }
}
