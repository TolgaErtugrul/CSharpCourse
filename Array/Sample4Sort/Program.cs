// Array.Sort(...) diye bir metot var , elinizdeki diziyi sıralar.
// 
// int[] sayilar = new int[5];
int[] sayilar = { 22, 12, 50, -3, 5 };
// DİZİYİ YAZDIR
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
Array.Sort(sayilar); // diziyi sıralar
Console.WriteLine("---- SIRALANMIŞ DİZİ ----");
 // Diziyi yazdır
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
// Diziyi ters çevirir.
Array.Sort(sayilar);
Array.Reverse(sayilar); 
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
// Dizi küçükten büyüğe sıralanınca ilk eleman -> en küçük eleman.
Array.Sort(sayilar);
Console.WriteLine(sayilar[0]);
// Dizi sıralanınca son index -> en büyük eleman.
Array.Sort(sayilar);
Console.WriteLine(sayilar[sayilar.Length-1]);
// Dizinin eleman sayısını 1 artırıyorum.
Array.Resize(ref sayilar, sayilar.Length + 1); 
sayilar[sayilar.Length - 1] = Convert.ToInt32(Console.ReadLine());
            