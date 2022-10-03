using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndSealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kuslar kus = new Kuslar();
            kus.Adaptasyon();
            kus.Ucmak();

            Console.WriteLine("*******************************************");

            TohumluBitkiler bitki = new TohumluBitkiler();
            bitki.FotosentezYapmak();
            bitki.TohumlaUreme();
        }
    }
}
