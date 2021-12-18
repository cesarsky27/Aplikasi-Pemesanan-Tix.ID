using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class PromoMakanan : MenuMakanan
    {
        public int Diskon { get; set; }

        public override void ListMakanan()
        {
            base.ListMakanan();
            Console.WriteLine($"POTONGAN HARGA: Rp. {Diskon}");
        }
    }
}
