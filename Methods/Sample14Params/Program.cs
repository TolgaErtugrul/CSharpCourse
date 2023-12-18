// MetotlarParamsKavrami
// Sayısız parametreyi , tek bir dizi olarka toplayıp , işlem yapmak istiyorsak kullanabileceğimiz yapıdır.
decimal FiyatlariHesapla(params decimal[] fiyatlar)
{
    decimal toplamFiyat = 0;
    foreach (var f in fiyatlar)
    {
        toplamFiyat = toplamFiyat + f;
    }
    return toplamFiyat;
}
decimal odenecekTutar = FiyatlariHesapla(1, 4, 5, 6, 7, 8, 111, 3, 3123, 3213123, 32131);
Console.WriteLine("Toplam Ödenecek Tutar : " + odenecekTutar + " TL");