using System;
using System.Collections.Generic;

namespace ProgramLaundry
{
    class Program : Pelanggan
    {
        static void Main(string[] args)
        {
            int exit = 0;
            
            List<Pelanggan> Pel = new List<Pelanggan>();

            do
            {
                Console.WriteLine("————————————————————————————————————————");
                Console.WriteLine("Program Sederhana Laundry");
                Console.WriteLine("————————————————————————————————————————");
                Console.WriteLine("Harga Laundry Rp5000/kg");
                Console.WriteLine("————————————————————————————————————————");
                Console.WriteLine("1. Daftar Pelanggan");
                Console.WriteLine("2. Menampilkan Data Pelanggan Keseluruhan");
                Console.WriteLine("3. Menampilkan Data Pelanggan berdasarkan id");
                Console.WriteLine("4. Update Pelanggan");
                Console.WriteLine("5. Diskon Pelanggan");
                Console.WriteLine("6. Hapus Pelanggan");
                Console.WriteLine("7. Keluar");
                Console.WriteLine("————————————————————————————————————————");
                Console.WriteLine("\n");

                int c;
                Console.Write("Pilihan anda = ");
                try
                { 
                    c = int.Parse(Console.ReadLine());

                    switch (c)
                    {
                        case 1:
                            Console.Clear();
                            DaftarPelanggan(Pel);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            TampilPelanggan(Pel);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("————————————————————————————————————————");
                            Console.WriteLine("Anda memilih Tampilan Pelanggan Berdasarkan id");
                            Console.WriteLine("————————————————————————————————————————");
                            Console.Write("Input id = ");
                            string id = Console.ReadLine();
                            TampilPelangganSearchId(Pel, id);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            UpdatePelanggan(Pel);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            Console.Clear();
                            DiskonPelanggan(Pel);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 6:
                            Console.Clear();
                            HapusPelanggan(Pel);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 7:
                            exit = 7;
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Pilih Ulang");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Pilih Ulang ya gais");
                    Console.ReadLine();
                    Console.Clear(); ;
                }
            }
            while (exit != 7);
        }

        public static void DaftarPelanggan(List<Pelanggan> Pel)
        {
            Console.WriteLine("————————————————————————————————————————");
            Console.WriteLine("Anda memilih Daftar Pelanggan");
            Console.WriteLine("————————————————————————————————————————");

            Console.Write("Input id = ");
            string id = (Console.ReadLine());

            Console.Write("Input nama = ");
            string nama = (Console.ReadLine());

            Console.Write("Input nomor telepon = ");
            int nmr = int.Parse(Console.ReadLine());

            Console.Write("Input alamat = ");
            string almt = (Console.ReadLine());

            Console.Write("Input totalberat = ");
            double b = double.Parse(Console.ReadLine());

            Pel.Add(new Pelanggan(id, nama, nmr, almt, b));
            Console.WriteLine();
        }

        public static void TampilPelanggan(List<Pelanggan> Pel)
        {
            Console.WriteLine("————————————————————————————————————————");
            Console.WriteLine("Anda memilih Tampilan Pelanggan");
            Console.WriteLine("————————————————————————————————————————");

            foreach (var p in Pel)
            {
                Console.WriteLine($"Id Pelanggan : {p.IdPelanggan}");
                Console.WriteLine($"Nama Pelanggan : {p.NamaPelanggan}");
                Console.WriteLine($"Nomor Telepon : {p.NoTelepon}");
                Console.WriteLine($"Alamat Pelanggan : {p.AlamatPelanggan}");
                Console.WriteLine($"Total Berat Laundry : {p.TotalBerat} kg");
                Console.WriteLine($"Total Harga Laundry :  {p.TotalHarga}");
                Console.WriteLine("\n");
            }
        }

        public static void TampilPelangganSearchId(List<Pelanggan> Pel, string id)
        {
            foreach (var p in Pel)
            {
                if (id == p.IdPelanggan)
                {
                    Console.WriteLine($"Id Pelanggan : {p.IdPelanggan}");
                    Console.WriteLine($"Nama Pelanggan : {p.NamaPelanggan}");
                    Console.WriteLine($"Nomor Telepon : {p.NoTelepon}");
                    Console.WriteLine($"Alamat Pelanggan : {p.AlamatPelanggan}");
                    Console.WriteLine($"Total Berat Laundry : {p.TotalBerat} kg");
                    Console.WriteLine($"Total Harga Laundry :  {p.TotalHarga}");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static void UpdatePelanggan(List<Pelanggan> Pel)
        {
            Console.WriteLine("————————————————————————————————————————");
            Console.WriteLine("Anda memilih Update Pelanggan");
            Console.WriteLine("————————————————————————————————————————");

            Console.Write("Input id : ");
            string a = Console.ReadLine();

            foreach (var p in Pel)
            {
                if (a == p.IdPelanggan)
                {
                    Console.WriteLine($"Id Pelanggan : {p.IdPelanggan}");
                    Console.WriteLine($"Nama Pelanggan : {p.NamaPelanggan}");
                    Console.WriteLine($"Nomor Telepon : {p.NoTelepon}");
                    Console.WriteLine($"Alamat Pelanggan : {p.AlamatPelanggan}");
                    Console.WriteLine($"Total Berat Laundry : {p.TotalBerat} kg");
                    Console.WriteLine($"Total Harga Laundry :  {p.TotalHarga}");
                    Console.WriteLine("\n");

                    Console.Write("Input Nomor Telepon = ");
                    p.NoTelepon = int.Parse(Console.ReadLine());
                    
                    Console.Write("Input alamat = ");
                    p.AlamatPelanggan =(Console.ReadLine());

                    Console.Write("Input tambahberat = ");
                    double tambahBerat = double.Parse(Console.ReadLine());

                    double z = tambahBerat * 5000;
                    Console.WriteLine($"z = {z}");
                    Console.WriteLine();

                    p.TotalBerat = p.TotalBerat + tambahBerat;
                    Console.WriteLine($"Total Berat = {p.TotalBerat}");
                    Console.WriteLine();

                    p.TotalHarga = z + p.TotalHarga;
                    Console.WriteLine($"Total Harga = {p.TotalHarga}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static void DiskonPelanggan(List<Pelanggan> Pel)
        {
            Console.WriteLine("————————————————————————————————————————");
            Console.WriteLine("Anda memilih Diskon");
            Console.WriteLine("————————————————————————————————————————");

            Console.Write("Input id : ");
            string a = Console.ReadLine();

            foreach(var p in Pel)
            {

                if (a == p.IdPelanggan)
                {
                    Console.WriteLine($"Id Pelanggan : {p.IdPelanggan}");
                    Console.WriteLine($"Nama Pelanggan : {p.NamaPelanggan}");
                    Console.WriteLine($"Nomor Telepon : {p.NoTelepon}");
                    Console.WriteLine($"Alamat Pelanggan : {p.AlamatPelanggan}");
                    Console.WriteLine($"Total Berat Laundry : {p.TotalBerat} kg");
                    Console.WriteLine($"Total Harga Laundry :  {p.TotalHarga}");
                    Console.WriteLine("\n");

                    if (p.TotalBerat >= 0 || p.TotalBerat <= 5)
                    {
                        double hargaDiskon = p.TotalHarga * 0.2;
                        Console.WriteLine($"Harga Diskon = {hargaDiskon}");
                        Console.WriteLine();

                        p.TotalHarga = p.TotalHarga - hargaDiskon;
                        Console.WriteLine($"Total Harga = {p.TotalHarga}");
                        Console.WriteLine();
                    }
                    else if (p.TotalBerat > 5 || p.TotalBerat <= 10)
                    {
                        double hargaDiskon = p.TotalHarga * 0.4;
                        Console.WriteLine($"Harga Diskon = {hargaDiskon}");
                        Console.WriteLine();

                        p.TotalHarga = p.TotalHarga - hargaDiskon;
                        Console.WriteLine($"Total Harga = {p.TotalHarga}");
                        Console.WriteLine();
                    }
                    else
                    {
                        double hargaDiskon = p.TotalHarga * 0.6;
                        Console.WriteLine($"Harga Diskon = {p.TotalHarga}");
                        Console.WriteLine();

                        p.TotalHarga = p.TotalHarga - hargaDiskon;
                        Console.WriteLine($"Total Harga = {p.TotalHarga}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public static void HapusPelanggan(List<Pelanggan> Pel)
        {
            Console.WriteLine("————————————————————————————————————————");
            Console.WriteLine("Anda memilih Hapus Pelanggan");
            Console.WriteLine("————————————————————————————————————————");

            Console.Write("Input id : ");
            string a = Console.ReadLine();
            Console.WriteLine();

            foreach (var p in Pel)
            {
                if (a == p.IdPelanggan)
                {
                    Pel.Remove(p);
                    Console.WriteLine("Data pelanggan sudah dihapus");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }  
}