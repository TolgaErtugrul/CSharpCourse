// 1 ile 50 arasında rastgele sayılardan oluşan 20 elemanlı bir array oluşturulacak.
// Bu elemanların sıralanması ve ortalamalarını ekrana yazdırınız.
Random rnd = new Random();
int[] sayilar = new int[20];
int toplam = 0;
for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rnd.Next(1, 51);
    toplam = toplam + sayilar[i];
}
Array.Sort(sayilar);
Console.WriteLine("---- SAYILAR ----");
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("ORTALAMA : " + toplam/sayilar.Length);