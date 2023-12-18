// Girilen bir sayının asal olup olmadığını söyleyen ve bu sayıdan sonra gelen ilk 5 asal sayıyı ekrana yazdıran bir program.
// Asal Sayı -> Yalnızca kendisine ve 1'e tam bölünebilen.
// AsalMi() -> diye bir metodumuz olsun, içerisine sayı bilgisi gönderildiğinde true ya da false şeklinde bize durum bildirsin.
bool AsalMi(int sayi)
{
    if (sayi == 1)
        return false;

    for (int i = 2; i < sayi; i++)
    {
        if (sayi % i == 0)
            return false;
    }
    return true;
}
Console.WriteLine("Kontrol etmek istediğiniz sayıyı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());
if (AsalMi(sayi))
{
    Console.WriteLine("Sayı asaldır.");
}
else
{
    Console.WriteLine("Sayı asal değildir.");
}
// Bu sayıdan sonra gelen 5 asal sayıyı yazdıracağız.
int sayac = 0; // Her asal sayı yakaladığımda +1
while (true)
{
    sayi++;

    if(AsalMi(sayi))
    {
        Console.WriteLine(sayi);
        sayac++;
    }

    if (sayac == 5) // bulduğun asal sayı sayısı 5 olunca , döngüden çık
        break;
}
// *'lı örnek , üzerinde durulsun !
// DO WHILE ILE YAPIM
//do
//{
//    sayi++;
//    if(AsalMi(sayi))
//    {
//        Console.WriteLine(sayi);
//        sayac++;
//    }
//} while (sayac != 5);