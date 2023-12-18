// Ekrana "Ben bir metodum" yazan bir metot.
void Yaz()
{
    Console.WriteLine("Ben bir Metodum.");
}
Yaz();
// Kişilerin isim ve soyisim bilgilerini alıp , Sayın {isim} {soyisim} şeklinde ekrana yazan bir metot.
void Hitap(string isim , string soyisim)
{
    Console.WriteLine("Sayın " + isim + " " + soyisim);
}
Hitap("Ajda", "Pekkan");
// 1'den 10'a kadar çift sayıları ekrana yazan bir metot.
void Say()
{
    for (int i = 0; i < 10; i++)
    {
        if(i % 2 == 0)
            Console.WriteLine(i);
    }
}
Say();
// 1'den aldığı limit parametresine kadar olan tek sayıları ekrana yazan metot.
void Say2(int limit)
{
    for (int i = 0; i < limit; i++)
    {
        if(i % 2 != 0)
            Console.WriteLine(i);
    }
}
Say2(15);
// Kişinin doğum yılı bilgisini alıp , yaş bilgisini geriye dönen bir metot.
int YasHesapla(int dogumYili)
{
    return DateTime.Now.Year - dogumYili;
}
YasHesapla(2000); // 23
Console.WriteLine( YasHesapla(2000) ); // metodun değeri bir değişkene atanıp , o şekilde de yazdırılabilir.
// Bir ürün fiyatı ve kdv oranı alıp , yeni fiyat bilgisi belirleyip geriye dönen bir metot.
decimal YeniFiyat(decimal fiyat , decimal kdvOrani)
{
    decimal yeniFiyat = fiyat + fiyat * kdvOrani / 100;
    return yeniFiyat;
}
Console.WriteLine("Fiyatı 100 TL olan 10% KDV'li bir ürünün yeni fiyatı : " + YeniFiyat(100 , 10) );
// Ekrana "Ben void bir metodum beni değişkene atayamazsın" yazan bir metot.
void Atar()
{
    Console.WriteLine("Ben void bir metodum , beni değişkene atayamazsın.");
}
Atar();
// string degisken = Atar(); ---> KIZAR
// Geriye "Ben değer döndüren bir metodum beni değişkene atayabilirsin" metnini döndüren bir metot yazınız.
string Atarsiz()
{
    return "Ben değer döndüren bir metodum , beni değişkene atayabilirsin.";
}
string degisken = Atarsiz();
/*
string degisken = "Ben değer döndüren bir metodum , beni değişkene atayabilirsin.";
*/