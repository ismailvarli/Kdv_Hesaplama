namespace Kdv_Hesaplama_Projesi
{
    internal class Program
    {      
            static void Main(string[] args)
            {
                
                string[] gida = { "Et", "Peynir", "Süt" };
                double[] gidaFiyat = { 250, 100, 45 };

                string[] giyim = { "Gömlek", "TShirt", "Etek" };
                double[] giyimFiyat = { 500, 300, 250 };

                string[] bujiteri = { "Ruj", "Toka", "Kolye" };
                double[] bujiteriFiyat = { 50, 20, 80 };

                double toplamTutar = 0;

               
                Console.WriteLine("Pazara hoş geldiniz, Ürünlerden almak istediklerinizi seçin.\n");

                Console.WriteLine("Gıda Kategorisi:");
                toplamTutar += UrunSecVeHesapla(gida, gidaFiyat, GidaKdvOrani());

                Console.WriteLine("\nGiyim Kategorisi:");
                toplamTutar += UrunSecVeHesapla(giyim, giyimFiyat, GiyimKdvOrani());

                Console.WriteLine("\nBujiteri Kategorisi:");
                toplamTutar += UrunSecVeHesapla(bujiteri, bujiteriFiyat, BujiteriKdvOrani());

                Console.WriteLine($"\nToplam ödemeniz gereken tutar: {toplamTutar}TL");
            }

            static double UrunSecVeHesapla(string[] urunler, double[] fiyatlar, double kdvOrani)
            {
                double toplam = 0;

                for (int i = 0; i < urunler.Length; i++)
                {
                    double fiyatKdvli = fiyatlar[i] + (fiyatlar[i] * kdvOrani);
                    Console.WriteLine($"{i + 1}. {urunler[i]} - Fiyat: {fiyatlar[i]} TL, KDV'li Fiyat: {fiyatKdvli}TL");
                }

                Console.WriteLine("Almak istediğiniz ürünün numarasını girin (Almak istemiyorsanız 0 girin): ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim > 0 && secim <= urunler.Length)
                {
                    toplam = fiyatlar[secim - 1] + (fiyatlar[secim - 1] * kdvOrani);
                    Console.WriteLine($"{urunler[secim - 1]} sepete eklendi. Ücret: {toplam}TL\n");
                }

                return toplam;
            }

            static double GidaKdvOrani()
            {
                return 0.20;
            }

            static double GiyimKdvOrani()
            {
                return 0.18; 
            }

            static double BujiteriKdvOrani()
            {
                return 0.10; 
            }

        }
    }
