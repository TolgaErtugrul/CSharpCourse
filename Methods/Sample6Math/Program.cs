// .Net içerisinde bir sürü kütüphane bulunur. Math kütüphanesi de bunlardan bir tanesi.
// Yuvarlama işlemleri , pi sayısı bilgisi , üst alma , kök alma vs.
Console.WriteLine(Math.PI);
// floor -> alt sayıya tamamlar.
Console.WriteLine("Alt sayıya tamamlamak istediğiniz değeri giriniz.");
double deger = Convert.ToDouble(Console.ReadLine());
double yeniDeger = Math.Floor(deger); // böyle yapılıp yazdırılabilir de.
Console.WriteLine(Math.Floor(deger));
// Ceiling -> üst sayıya tamamlar.
Console.WriteLine("üst sayıya yuvarlasaydık...");
Console.WriteLine(Math.Ceiling(deger));
Console.WriteLine("--------------------------------------");
// Round -> yuvarlama
Console.WriteLine(Math.Round(12.30));
Console.WriteLine(Math.Round(12.70));
Console.WriteLine(Math.Round(12.50));
Console.WriteLine(Math.Round(13.50));
// .50 her zaman çift olan değere tamamlanır.
// pow -> ilk parametre sayi , ikinci parametre kuvvet.
Console.WriteLine(Math.Pow(4,2));
Console.WriteLine(Math.Pow(5,3));
Console.WriteLine(Math.Pow(3,3));
Console.WriteLine(Math.Pow(3,-2));
// sqrt -> karekök alma.
Console.WriteLine(Math.Sqrt(16));