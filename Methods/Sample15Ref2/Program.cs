// Kullanıcıdan alınan 2 sayının yerlerini değiştiren bir metot.
// 1. Sayıyı giriniz
// 10
// 2. Sayıyı giriniz.
// 20
// 1. sayı -> 20
// 2. sayı -> 10
void yerDegistir(ref int sayi1, ref int sayi2)
{
    int gecici = sayi1;
    sayi1 = sayi2;
    sayi2 = gecici;
}
Console.WriteLine("1. sayıyı giriniz.");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz.");
int s2 = Convert.ToInt32(Console.ReadLine());
yerDegistir(ref s1, ref s2);
Console.WriteLine("Sayı 1 ----> " + s1);
Console.WriteLine("Sayı 2 -----> " + s2);