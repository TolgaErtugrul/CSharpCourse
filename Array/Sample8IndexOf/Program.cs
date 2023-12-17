// IndexOf metodu , bir eleman bir dizide mevcut mu yoksa değil mi bilgisini bize söyler.
// Eleman varsa onun index numarasını verir.
// Eleman yoksa -1 değerini verir.
// Kullanım -> Array.IndexOf( diziAdi , sorgulanacakDeger );
int[] sayilar = { 60, 80, 55 };
Console.WriteLine(Array.IndexOf(sayilar , 60));
Console.WriteLine(Array.IndexOf(sayilar, 80));
Console.WriteLine(Array.IndexOf(sayilar , 55)); ;
Console.WriteLine(Array.IndexOf(sayilar , 3)); // dizide olmadığından -1 yazar.
Console.WriteLine("------------------------------");
// örnek : 300 sayısı yukarıdaki sayilar dizisinde var mı yoksa yok mu kontrol eden uygulama
if(Array.IndexOf(sayilar , 300) == -1)
    Console.WriteLine("DİZİDEYOK!");
else
    Console.WriteLine("DİZİDE VAR!");

// Sayıca saymaz, ilk gördüğü verinin indexini döndürür.