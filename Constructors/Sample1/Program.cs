// Markası, Modeli, Rengi, KapıSayisi, UretimTarihi olan bir Araba nesnesi oluşturunuz.
// Nesne oluşturulduğunda "Vınnnn" diye bir motor sesi ekrana yazdırılsın.
// Kullanılabilecek 2 constructor seçeneği sunulacak.
// 1 -> Boş constructor, parametre almadan , hiç bir değer ataması yapmadan oluşturma.
// 2 -> Bütün parametreleri alıp, üretim tarihini de datetime.now ile kendisi atayan bir consturctor.
// İki consturctor ile de birer araba üretip , Marka + Model + Üretim tarihi bilgilerini ekrana yazdırınız.
using ConstructorOrnek1;
Araba a1 = new Araba();
Console.WriteLine(a1.Marka);
Console.WriteLine(a1.Model);
Console.WriteLine(a1.KapiSayisi);
// Başta constructor ile değer ataması yapılmadığı için, stringler null , int'ler 0 olarak oluşturuldu.
a1.Marka = "Honda";
a1.Model = "Civic 2020";
a1.KapiSayisi = 4;
a1.Renk = "Mavi";
a1.UretimTarihi = DateTime.Now;
Console.WriteLine("Değer atandıktan sonra");
Console.WriteLine(a1.Marka);
Console.WriteLine(a1.Model);
Console.WriteLine(a1.KapiSayisi);
Console.WriteLine("------------------------------------");
Araba a2 = new Araba("Mercedes", "A180 2010", "Kırmızı", 2);
Console.WriteLine(a2.Marka);
Console.WriteLine(a2.Model);
Console.WriteLine(a2.KapiSayisi);