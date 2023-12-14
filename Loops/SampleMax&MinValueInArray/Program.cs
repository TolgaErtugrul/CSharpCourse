// Kullanıcının gireceği sayılar arasından en büyük ve en küçük olan değerleri yazan bir uygulama
// Kaç sayı girileceğini yine kullanıcı kendisi belirleyecek.
// Kaç sayı gireceksiniz?
// Sayıları giriniz.
// 10
// 5
// 20
// 14
// 3
// -- En büyük : 20
// -- En küçük : 3
// Hint : Girilen sayı *ilk turda* hem en büyük , hem en küçük kabul edilir.

Console.WriteLine("Kaç sayı girmek istiyorsunuz ?");
int limit = Convert.ToInt32(Console.ReadLine());
int enBuyuk=0, enKucuk=0;
Console.WriteLine("Sayıları giriniz.");
for (int i = 0; i < limit; i++)
{
    int sayi = Convert.ToInt32(Console.ReadLine());
    if(i == 0) // ilk girilen sayıyı hem en büyük hem enküçük kabul etmek istiyorum.
    {
        enBuyuk = enKucuk = sayi;
    }
    if (sayi > enBuyuk)
        enBuyuk = sayi;
    if (sayi < enKucuk)
        enKucuk = sayi;
}
Console.WriteLine("En büyük : " + enBuyuk);
Console.WriteLine("En küçük : " + enKucuk);