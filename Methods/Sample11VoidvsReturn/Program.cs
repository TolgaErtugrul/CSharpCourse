// Ekrana "Onda bunda şundadır" yazmak istiyoruz. Bu işlemi ilk önce void metot kullarak sonra da return'lü bir metot kullanarak yapacağız.
// 1. Uygulama 
void Yazdir1()
{
    Console.WriteLine("Onda bunda şundadır.");
}
Yazdir1();
Console.WriteLine("-----------------------------");
// 2. Uygulama
string MesajDondur()
{
    return "Onda bunda şundadır.";
}
string mesaj = MesajDondur();
Console.WriteLine(mesaj);
Console.WriteLine("-----------------------------------");

// Ornek -> Kullanıcıdan 2 adet sayı alınsın. Bu sayıların toplamı metot yardımıyla ekrana yazdırılsın.
// Metot -> Topla
// 1.Uygulama -> Void bir Topla metodu , toplayıp ekrana yazdırma işlemini gerçekleştiriyor.
// 2.Uygulama -> Geriye toplam değerini dönen bir metot var, yazım işlemi programın kendisinde gerçekleşiyor.
void Topla(int s1, int s2)
{
    Console.WriteLine(s1+s2);
}
Console.WriteLine("1.Sayıyı giriniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Topla(sayi1, sayi2);
Console.WriteLine("----------------------");
int Topla2(int s1 , int s2)
{
    return s1 + s2;
}
Console.WriteLine("1.Sayıyı giriniz.");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı giriniz.");
sayi2 = Convert.ToInt32(Console.ReadLine());
int t = Topla2(sayi1, sayi2);
Console.WriteLine(t);