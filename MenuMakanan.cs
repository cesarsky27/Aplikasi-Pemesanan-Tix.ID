using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    public class MenuMakanan
    {
        public int Nomor { get; set; }
        public String Nama { get; set; }
        public int Harga { get; set; }

        public MenuMakanan()
        {

        }

        public MenuMakanan (int nomor, string nama, int harga)
        {
            Nomor = nomor;
            Nama = nama;
            Harga = harga;
        }

        public virtual void ListMakanan()
        { 
            Console.WriteLine("===============================================");
            Console.Write($"{Nomor}. ");
            Console.WriteLine($"Nama Makanan: {Nama}");
            Console.WriteLine($"Harga Makanan: Rp. {Harga}");
        }
    }
}
