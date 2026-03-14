using System;

namespace TP_Modul4_103022400022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== KODE POS =====");
            KodePos kodePos = new KodePos();

            string[] daftarKelurahan = {
                "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
                "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer"
            };

            foreach (string kelurahan in daftarKelurahan)
            {
                Console.WriteLine($"Kelurahan {kelurahan}: {kodePos.getKodePos(kelurahan)}");
            }
        }
    }
}