// Dikdörtgen biçiminde bir bahçemiz var. Etrafını çitle kaplamak istiyoruz. Ölçümler yapılıyor.
// Kullanıcıdan alınan en ve boy değerleri sonucunda bu bahçenin çevre uzunluğu hesaplayan bir metot olsun.
// Ardından bir metre çitin fiyatı = 20 TL bilgisi ile, toplam kaç tl masraf çıkacağını bize bildiren / ekrana yazdıran bir metot olsun.
// Bu 2 metotla çalışan uygulamayı yazınız.
// ilk metot -> çevre hesaplayan -> geriye çevre bilgisini dönsün.
// ikinci metot -> çevre bilgisi ile , fiyat hesaplayıp ekrana yazdırsın.
double CevreHesapla(double kisaKenar , double uzunKenar)
{
    double c = (kisaKenar + uzunKenar) * 2;
        return c;
}
void FiyatHesapla(double cevre)
{
    double fiyat = cevre * 20;
    Console.WriteLine("Toplam masraf : " + fiyat + " TL");
}
Console.WriteLine("Kısa kenar ölçüsünü giriniz.");
double kisaKenar = Convert.ToDouble(Console.ReadLine()); // 10
Console.WriteLine("Uzun kenar bilgisini giriniz.");
double uzunKenar = Convert.ToDouble(Console.ReadLine()); // 20
double cevre = CevreHesapla(kisaKenar, uzunKenar);
FiyatHesapla(cevre);