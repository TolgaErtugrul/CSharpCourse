// Kullanıcıdan 2 sayı alıp bunları ekrana yazdırınız.
// GeriyeDonulenDegerTipi MetotAdi(parametreTipi parametreAdi ...)
//{
           // return geriyeDonulenDeger
//}
int Topla(int s1 , int s2)
{
    return s1 + s2;
}
Console.WriteLine("1. sayıyı giriniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int toplam1 = Topla(sayi1, sayi2);
Console.WriteLine("Toplam 1 : "  + toplam1);
Console.WriteLine("3. sayıyı giriniz.");
int sayi3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("4. sayıyı giriniz.");
int sayi4 = Convert.ToInt32(Console.ReadLine());
int toplam2 = Topla(sayi3, sayi4);
Console.WriteLine("Toplam 2 : " + toplam2);