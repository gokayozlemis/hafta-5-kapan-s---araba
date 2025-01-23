using System;
using System.Collections.Generic;

class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    public Araba()
    {
        UretimTarihi = DateTime.Now;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();
        string cevap;

        do
        {
            Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
            cevap = Console.ReadLine().Trim().ToLower();

            if (cevap == "h")
            {
                Console.WriteLine("Program sonlandırılıyor...");
                break;
            }
            else if (cevap == "e")
            {
                Araba yeniAraba = new Araba();

                Console.Write("Seri Numarası: ");
                yeniAraba.SeriNumarasi = Console.ReadLine();

                Console.Write("Marka: ");
                yeniAraba.Marka = Console.ReadLine();

                Console.Write("Model: ");
                yeniAraba.Model = Console.ReadLine();

                Console.Write("Renk: ");
                yeniAraba.Renk = Console.ReadLine();

            tekrar:
                try
                {
                    Console.Write("Kapı Sayısı: ");
                    yeniAraba.KapiSayisi = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hatalı giriş! Lütfen sayısal bir değer giriniz.");
                    goto tekrar;
                }

                arabalar.Add(yeniAraba);
                Console.WriteLine("Araba başarıyla üretildi!\n");
            }
            else
            {
                Console.WriteLine("Geçersiz bir cevap verdiniz. Lütfen 'e' veya 'h' giriniz.");
            }

        } while (cevap != "h");

        Console.WriteLine("\nÜretilen arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }
}