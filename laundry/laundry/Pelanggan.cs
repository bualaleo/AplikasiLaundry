using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramLaundry
{
    class Pelanggan
    {
        public string IdPelanggan { get; set; }
        public string NamaPelanggan { get; set; }
        public int NoTelepon { get; set; }
        public string AlamatPelanggan { get; set; }
        public double TotalBerat { get; set; }
        public double TotalHarga { get; set; }

        public int t = 5000;

        public double total, totala;

        public Pelanggan() 
        { 
        
        }

        public Pelanggan(string idPel, string namaPel, int noTel, string alamatPel, double totalBer)
        {
            this.IdPelanggan = idPel;
            this.NamaPelanggan = namaPel;
            this.NoTelepon = noTel;
            this.AlamatPelanggan = alamatPel;
            this.TotalBerat = totalBer;
            this.TotalHarga = HitungHarga(totalBer);
        }

        public double HitungHarga(double totalBer)
        {
            total = this.TotalBerat * t;
            return total;
        }
    }
}
