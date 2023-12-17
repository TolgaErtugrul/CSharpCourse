// Kullanıcıya kaç sayı gireceğini soran
// Kullanıcıdan aldığı sayı boyutunda bir dizi oluşturup
// Girilen sayıları bu diziye ekleyen
// ardından dizinin büyükten küçüğe sıralanmış halini ve en küçük elemanını ekrana yazdıran bir uygulama.
Console.WriteLine("Kaç sayı gireceksiniz?");
int elemanSayisi = Convert.ToInt32(Console.ReadLine());
int[] sayilar = new int[elemanSayisi];
for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine("Sayi giriniz :");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(sayilar); // sirala
Array.Reverse(sayilar); // ters çevir
Console.WriteLine("----SAYILAR----");
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("Dizinin En Küçük Elemanı ----> " + sayilar[sayilar.Length-1]);