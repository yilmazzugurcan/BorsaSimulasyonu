using System;

namespace BorsaSimulasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double bakiye = 10000;

            
            int hisseSenediAdedi = 0;

            
            double hisseSenediFiyati = 50;

            
            Console.WriteLine("Borsa Simülasyonuna Hoş Geldiniz!");

            
            while (true)
            {
                // Menü 
                Console.WriteLine("1. Hisse Senedi Satın Al");
                Console.WriteLine("2. Hisse Senedi Sat");
                Console.WriteLine("3. Bakiye Sorgula");
                Console.WriteLine("4. Hisse Senedi Sorgula");
                Console.WriteLine("5. Programdan Çık");
                Console.Write("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                // Seçime göre işlem yapılır
                switch (secim)
                {
                    case 1: // Hisse senedi alma
                        Console.Write("Satın almak istediğiniz hisse senedi adedi: ");
                        int adet = Convert.ToInt32(Console.ReadLine());
                        double toplamTutar = hisseSenediFiyati * adet;
                        if (bakiye >= toplamTutar)
                        {
                            bakiye -= toplamTutar;
                            hisseSenediAdedi += adet;
                            Console.WriteLine("{0} adet hisse senedi satın aldınız. Yeni bakiyeniz: {1}", adet, bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Bakiyeniz yetersiz!");
                        }
                        break;

                    case 2: // Hisse senedi satma
                        Console.Write("Satmak istediğiniz hisse senedi adedi: ");
                        adet = Convert.ToInt32(Console.ReadLine());
                        if (adet <= hisseSenediAdedi)
                        {
                            bakiye += hisseSenediFiyati * adet;
                            hisseSenediAdedi -= adet;
                            Console.WriteLine("{0} adet hisse senedi sattınız. Yeni bakiyeniz: {1}", adet, bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Sahip olduğunuz hisse senedi adedinden daha fazla satamazsınız!");
                        }
                        break;

                    case 3: // Bakiye sorgula
                        Console.WriteLine("Bakiyeniz: {0}", bakiye);
                        break;

                    case 4: // Hisse senedi sorgula
                        Console.WriteLine("Sahip olduğunuz hisse senedi adedi: {0}", hisseSenediAdedi);
                        break;

                    case 5: // Programdan çık
                        Console.WriteLine("Programdan çıkılıyor...");
                        Environment.Exit(0);
                        break;

                    default: // Geçersiz seçim
                        Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                        break;
                }

                // Yeni hisse senedi fiyatı belirlenir
                Random r = new Random();
                double degisim = r.NextDouble() * 10 - 5; // -5 ile +5 arasında rastgele bir değişim belirler
                hisseSenediFiyati += degisim;

                // Yeni hisse senedi fiyatı ekrana yazdırılır
                Console.WriteLine("Yeni hisse senedi fiyatı: {0}", hisseSenediFiyati);
            }
        }
    }
}