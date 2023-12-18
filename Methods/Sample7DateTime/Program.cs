// ** burası önemli
// DATETIME -> Zamanla ilgili metotlar
// Anlık tarih ve saat bilgisi
Console.WriteLine(DateTime.Now);
// Anlık tarih
Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
// Anlık saat
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());
// Gün - Ay - Yıl bilgilerini ayrı ayrı almak.
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
// Haftanın hangi günü
Console.WriteLine(DateTime.Now.DayOfWeek);
// Tarih Formatla
Console.WriteLine(DateTime.Now.Year + " -/- " + DateTime.Now.Month + " -/- " + DateTime.Now.Day);
// Yeni tarih oluşturma
DateTime yeniZaman = new DateTime(1990, 06, 25, 00, 01, 00);
Console.WriteLine(yeniZaman);
// Zaman farkı
TimeSpan zamanFarki = DateTime.Now - yeniZaman;
Console.WriteLine(zamanFarki.TotalDays);
Console.WriteLine(Math.Round(zamanFarki.TotalDays) + " gündür yaşıyorsunuz.");