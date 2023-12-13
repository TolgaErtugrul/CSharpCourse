// Tek satırda ufak bir karar mekanizması ile yolumuza devam etmek istersek, soru işareti operatoru bize bu pratikliği sağlar.
// Yazım formatı :
// Kontrol edilecek değer ? olumlu ise : olumsuz ise

string sonuc;
int sayi = 4;
sonuc = sayi > 0 ? "Sayı pozitiftir." : "Sayı negatiftir";
Console.WriteLine(sonuc);

// alttaki kısım yerine üstteki gibi ternaryIf kullanılabilir.
if( sayi > 0)
{
    sonuc = "Sayı pozitiftir";
}
else
{
    sonuc = "Sayı negatiftir.";
}

// Kullanıcının girdiği sayının tek mi çift mi olduğunu yazdırmak.
sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( sayi % 2 == 0 ? "ÇİFTTİR" : "TEKTİR");

// Kullanıcının girdiği sayı 10'dan büyük mü değil mi bunu bize söyleyen bir kod.
Console.WriteLine( sayi > 10 ? "10'dan büyüktür" : "10'dan küçük veya eşittir.");