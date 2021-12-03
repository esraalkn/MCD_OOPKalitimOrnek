using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPKalitimOrnek
{
   public class Turk:Insan
    {
        public override void Selamlasma()
        {
            //Bu class da virtual sanal metodu ezmeme gerek yok .
            //Çünkü Türklerde Selamın aleyküm diye selam verir.
            base.Selamlasma();
        }
    }
}
