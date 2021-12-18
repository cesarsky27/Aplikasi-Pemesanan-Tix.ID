using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class SinopsisFilm
    {
        public int Nomor { get; set; }
        public string Movie { get; set; }
        public string Sinopsis { get; set; }

        public SinopsisFilm()
        {

        }

        public SinopsisFilm(int nomor, string movie, string sinopsis)
        {
            Nomor = nomor;
            Movie = movie;
            Sinopsis = sinopsis;
        }

        public virtual void ListSinopsis()
        {
            Console.WriteLine("=====================================================================================");
            Console.Write($"{Nomor}. ");
            Console.WriteLine($"Nama Film: {Movie}");
            Console.WriteLine($"Sinopsis Film: {Sinopsis}");
        }
        
     
    }
}
