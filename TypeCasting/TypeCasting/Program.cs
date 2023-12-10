/*
Kullanıcıdan alınan 2 sayının toplamını ekrana yazdıralım.

int sayi1, sayi2, toplam;

Console.WriteLine("Birinci sayıyı giriniz.");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz.");
sayi2 = Convert.ToInt32(Console.ReadLine());

toplam = sayi1 + sayi2;
Console.WriteLine(toplam);

//Convert.ToInt32("4"); metinsel ifade olan 4'ü ,  tam sayıya çevirir.
*/

//Kullanıcıdan alınan dörtgenin kısa ve uzun kenar bilgileri ile, ayrı ayro alan ve çevre bilgilerini hesaplayan bir uygulama yazınız.

double kisaKenar, uzunKenar, cevre, alan;

System.Console.WriteLine("Kısa kenar uzunluğu giriniz.");
kisaKenar = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Uzun kenar uzunluğunu giriniz.");
uzunKenar = Convert.ToDouble(Console.ReadLine());

cevre = (kisaKenar + uzunKenar)*2;
System.Console.WriteLine("Çevre uzunluğu : " + cevre);

alan= kisaKenar * uzunKenar;
System.Console.WriteLine("Alan : " + alan);