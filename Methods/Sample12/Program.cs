// Kullanıcıdan yaş bilgisi alıp , giriş yapabilir veya yapamaz durum bilgisi üzerinden çalışan bir uygulama
// 1.yöntem -> Yaş bilgisini metot alsın, kullanıcı 18 yaşından büyükse "Giriş yapılabilir" değilse "Yaşınız uygun olmadığından, giriş yapılamaz." yazdıran bir metot yardımıyla.
// 2.yöntem -> Yaş bilgisini metot aslın , geriye true ya da false şeklinde bir durum dönsün. 18'den büyükse true , değilse false
// 1.Yöntem
void YasKontrol(int yas)
{
    if(yas > 18)
        Console.WriteLine("Giriş yapılabilir.");
    else
        Console.WriteLine("Yaşınız uygun olmadığından , giriş yapılamaz.");
}
Console.Write("Yaş :");
int yas = Convert.ToInt32(Console.ReadLine());
YasKontrol(yas);

// 2.Yöntem
bool YasKontrol2(int yas)
{
    if (yas > 18)
        return true;
    else
        return false;
}
YasKontrol2(yas); // Bu sana true ya da false değer döner , sen ne yaparsan yap.
bool resitMi = YasKontrol2(yas);
if(resitMi == true) // == true kısmı yazılmasa da olur
    Console.WriteLine("GİRİŞ YAPILABILIR.");
else
    Console.WriteLine("GİRİŞ YAPILAMAZ.");