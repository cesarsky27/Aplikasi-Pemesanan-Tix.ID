using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class Program
    {
        static void ListSinopsis()
        {
            SinopsisFilm film1 = new SinopsisFilm(1, "Insidious 3: The Last Chapter", " berkisah tentang bagaimana paranormal berbakat Elise Rainier \n" +
                "dengan enggan setuju untuk menggunakan kemampuannya untuk menghubungi\n" +
                "orang mati guna membantu seorang gadis remaja yang telah ditargetkan oleh entitas supranatural yang berbahaya");
            SinopsisFilm film2 = new SinopsisFilm(1, "Spiderman: No Way Home", "Mengisahkan dilema yang dirasakan Peter Parker setelah ia difitnah dan \n" +
                "indentitasnya dibongkar oleh Mysterio sebelum tewas dalam pertarungan di London");
            SinopsisFilm film3 = new SinopsisFilm(3, "Gundala", "film ini menceritakan tentang kehidupan seseorang bernama Sancaka untuk \n" +
                "bertahan hidup ditengah kehidupannya yang begitu berat pasca ditinggal oleh orang tuanya");
            SinopsisFilm film4 = new SinopsisFilm(4, "Fast n Furious", "berkisah tentang seseorang bernama Brian O'Connor (Paul Walker) yang merupakan polisi terbaik.\n" +
                "Ia mempunyai misi untuk membongkar kasus pembajakan truk barang. Menariknya, pembajakan itu berhubungan dengan sebuah balapan mobil. \n" +
                "O'Connor lantas menyamar untuk membongkar dalang tersebut");
            SinopsisFilm film5 = new SinopsisFilm(5, "Man in Black", " berkisah mengenai agen M yang membantu debut agen H alias Molly Wright sebagai mata-mata.\n" +
                "Untuk menemukan mata-mata pengkhianat dalam organisasi Men In Black adalah misi yang harus diembannya");

            film1.ListSinopsis();
            film2.ListSinopsis();
            film3.ListSinopsis();
            film4.ListSinopsis();
            film5.ListSinopsis();
        }
        static void ListMenu()
        {
            int pilihMakan, jumlahMakan, totalMakan;
            MenuMakanan steak = new MenuMakanan(1, "Steak", 70000);
            MenuMakanan popcorn = new MenuMakanan(2, "Popcorn", 30000);
            PromoMakanan paket1 = new PromoMakanan();
            paket1.Nomor = 3;
            paket1.Nama = "Popcorn + Coca-cola";
            paket1.Harga = 40000;
            paket1.Diskon = 10000;

            steak.ListMakanan();
            popcorn.ListMakanan();
            paket1.ListMakanan();
            Console.Write("Pilih Makanan: ");

            pilihMakan = Convert.ToInt32(Console.ReadLine());
                switch (pilihMakan)
                {
                    case 1:
                        Console.Write("Berapa yang ingin anda beli? ");
                    do
                    {
                        try
                        {
                            jumlahMakan = Convert.ToInt32(Console.ReadLine());
                            totalMakan = jumlahMakan * 70000;
                            Console.WriteLine("Total Makanan anda adalah: " + "Rp. " + totalMakan);
                            randomTiket2();
                            Pesan2();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Inputan harus angka!");
                        }
                    } while (true);

                    case 2:
                        Console.WriteLine("Berapa yang ingin anda beli? ");
                    do
                    {
                        try
                        {
                            jumlahMakan = Convert.ToInt32(Console.ReadLine());
                            totalMakan = jumlahMakan * 30000;
                            Console.WriteLine("Total Makanan anda adalah: " + totalMakan);
                            randomTiket2();
                            Pesan2();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Inputan harus angka!");
                        }
                    } while (true);

                    case 3:
                    Console.WriteLine("Berapa yang ingin anda beli? ");
                    do
                       {
                        try
                        {
                            jumlahMakan = Convert.ToInt32(Console.ReadLine());
                            totalMakan = jumlahMakan * 40000 - 10000;
                            Console.WriteLine("Anda mendapat potongan sebesar Rp. 10.000");
                            Console.WriteLine("Total makanan anda adalah: " + totalMakan);
                            randomTiket2();
                            Pesan2();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Inputan harus angka!");
                        }
                    } while (true); 
                }
            } 
        static void Pesan()
        {
            Console.WriteLine("Pastikan anda memilih film yang benar");
        }

        static void Pesan2()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("(1) Pilih Film (2) Pilih Makanan (3) Sinopsis Film (4) Exit");
        }
        static void Hitung()
        {
            Console.WriteLine("Berapa tiket yang ingin anda beli: (Harga 1 Film Rp. 30.000)");
            do
            {
                try
                {
                    Console.Write("=> ");
                    int Tiket = Convert.ToInt32(Console.ReadLine());
                    int totalTiket = Tiket * 30000;
                    //Normal String
                    Console.WriteLine("Harga yang harus anda bayar adalah: Rp. " + totalTiket+", 00");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Inputan harus angka !!!");
                }
            } while (true);
            
        }

        static void randomTiket()
        {
            Random nilai = new Random();
            int a;
            a = nilai.Next(1, 10000);
            Console.WriteLine("Nomor Tiket anda adalah: " +" TX"+a);
            Console.WriteLine("Selamat menonton!");
            Pesan2();
        }

        static void randomTiket2()
        {
            Random nilai2 = new Random();
            int b;
            b = nilai2.Next(1, 10000);
            Console.WriteLine("Nomor pesanan anda adalah: " + " MK" +b);
            Console.WriteLine("Selamat menikmati!");
        }

        static void Main(string[] args)
        {
            int pilih;
            string[] pilihanMenu = new String[4] { "Pesan Tiket", "Pesan Makanan", "Sinopsis Film", "Exit" };
            string[] film = new String[5] { "Insidious 3: The Last Chapter", "Spider-man: No way home", "Gundala", "Fast Furious", "Man in Black" };
            
            Console.WriteLine("===============================================");
            Console.WriteLine("Selamat datang di Aplikasi Tix.ID            II");
            Console.WriteLine("===============================================");
            Console.WriteLine("Silahkan pilih menu: ");
            for (int i = 0; i < pilihanMenu.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + pilihanMenu[i]);
            }
            do
            {
                Console.Write("=> ");
                pilih = Convert.ToInt32(Console.ReadLine());
                if (pilih < 1 || pilih > 4)
                {
                    Console.WriteLine("Menu yang anda pilih tidak ada, Masukkan menu kembali!");
                    Console.WriteLine("===============================================");
                    Console.Write("=> ");
                }
                switch (pilih)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Berikut film-film yang kami sediakan: ");
                        for (int i = 0; i < film.Length; i++)
                        {
                            Console.WriteLine(i + 1 + ". " + film[i]);
                        }
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Pilih film yang ingin anda tonton: ");
                        Console.Write("=> ");
                        int menu = Convert.ToInt32(Console.ReadLine());

                        if (menu < 1 || menu > 5)
                        {
                            Console.WriteLine("Film yang anda pilih tidak ada");
                        }
                        switch (menu)
                        {
                            case 1:
                                //String Interpolated
                                Console.Clear();
                                Console.WriteLine($"Anda memilih nomor: {menu} dan anda akan menonton film {film[0]}");
                                Pesan();
                                Hitung();
                                randomTiket();
                                break;
                            case 2:
                                //String Interpolated
                                Console.Clear();
                                Console.WriteLine($"Anda memilih nomor: {menu} dan anda akan menonton film {film[1]}");
                                Pesan();
                                Hitung();
                                randomTiket();
                                break;
                            case 3:
                                //String Interpolated
                                Console.Clear();
                                Console.WriteLine($"Anda memilih nomor: {menu} dan anda akan menonton film {film[2]}");
                                Pesan();
                                Hitung();
                                randomTiket();
                                break;
                            case 4:
                                //String Interpolated
                                Console.Clear();
                                Console.WriteLine($"Anda memilih nomor: {menu} dan anda akan menonton film {film[3]}");
                                Pesan();
                                Hitung();
                                randomTiket();
                                break;
                            case 5:
                                //String Interpolated
                                Console.Clear();
                                Console.WriteLine($"Anda memilih nomor: {menu} dan anda akan menonton film {film[4]}");
                                Pesan();
                                Hitung();
                                randomTiket();
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("===============================================");
                        Console.WriteLine("List Makanan Tix.ID");
                        ListMenu();
                        Pesan2();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("=====================================================================================");
                        Console.WriteLine("                             Sinopsis Film:                                        ||");
                        //int totalHarga;
                        ListSinopsis();
                        Pesan2();
                        break;
                    case 4:
                        Console.WriteLine("Terima kasih telah menggunakan aplikasi Tix.ID");
                        System.Environment.Exit(1);
                        break;
                }
            } while (true);
        }
    }
}