using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndSealed
{

    // Sealed anahtar kelimesi erişimi engellemek için kullanılır.
    public sealed class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenirler.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yaparlar.");
        }

        public void Bosaltım()
        {
            Console.WriteLine("Canlılar boşaltım yaparlar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verirler.");
        }
    }
}
