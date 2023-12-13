// Eğer birden fazla EŞİT OLMA durumu kontrolü yapılacaksa, tek bir bilgi için, switch case kullanılabilir.
Console.WriteLine("Deneme amaçlı bir sayı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());
switch (sayi) // parantez içerisine kontrol edilecek degisken
{
    case 1: // sayı değeri 1 ise , break'e kadar olan kodları çalıştır.
        Console.WriteLine("SAYINIZ 1 !");
        break;
    case 2:
        Console.WriteLine("SAYINIZ 2 !");
        break;
    case 3:
    case 4:
    case 5: // bir nevi veya karşılığı
        Console.WriteLine("SAYINIZ 3 , 4 veya 5 !");
        break;
    default: // else karşılığı
        Console.WriteLine("SAYINIZ 1 - 2 - 3 - 4 -5 'ten biri değil");
        break;
}
// Kullanıcıdan alınan ay (sayı) bilgisi doğrultusunda , hangi mevsimde olduğunu ekrana yazdıran uygulama.
int ay = Convert.ToInt32(Console.ReadLine());
switch (ay)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("KIŞ MEVSİMİ");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İLKBAHAR MEVSİMİ");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("YAZ MEVSİMİ");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("SONBAHAR MEVSİMİ");
        break;
    default:
        Console.WriteLine("SEN BAŞKA BİR DÜNYADASIN , ÖYLE BİR AY YOK ! ");
        break;
}
// : -> scope başlangıcı
// çalışmasını istediğimiz tipler.
// break; -> scope bitişi

// Girilen sayının tek mi yoksa çift mi olduğunu switch-case kullanarak hesaplayan bir uygulama yazınız.
int sayi = Convert.ToInt32(Console.ReadLine());
switch (sayi%2)
{
    case 0:
        Console.WriteLine("SAYI ÇİFTTİR");
        break;
    default:
        Console.WriteLine("SAYI TEKTİR");
        break;
}
// Üstteki yazım sanki biraz daha temiz...
/*
switch (sayi % 2)
{
    case 0:
        Console.WriteLine("SAYI ÇİFTTİR");
        break;
    case 1:
    case -1:
        Console.WriteLine("SAYI TEKTİR");
        break;
}
*/

// BİR MANAV UYGULAMASI
// Kullanıcı fiyatını öğrenmek istediği meyvenin adını girecek.
// büyük-küçük harf duyarlılığı olmasın
// Elma -> 10TL
// Armut -> 10TL
// Çilek -> 20TL
// Muz -> 30TL
// Geri kalan her şey -> 40TL

Console.WriteLine("Fiyatını öğrenmek istediğiniz ürünün adını giriniz.");
string meyve = Console.ReadLine();
decimal urunFiyat;
switch (meyve.ToLower()) // ElMa girse > elma olarak kontrol
{
    case "elma":
    case "armut":
        urunFiyat = 10;
        break;
    case "çilek":
        urunFiyat = 20;
        break;
    case "muz":
        urunFiyat = 30;
        break;
    default:
        urunFiyat = 40;
        break;
}
Console.WriteLine("ÜRÜN FİYAT : " + urunFiyat + " TL");
// meyve = meyve.toLower() demediğim sürece ramdeki halini değiştirmiyorum.

// Float tipinde iki sayı alalım ve bir işlem türü ( + , - , / , * ) char tipinde
// girilen verilere göre işlem sonucunu ekrana yazdıran uygulama

float sayi1, sayi2;
char islemTipi;
Console.WriteLine("1. Sayıyı giriniz.");
sayi1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("2. Sayıyı giriniz.");
sayi2 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Yapmak isteiğiniz işlemin türünü ( + - / * ) giriniz.");
islemTipi = Convert.ToChar(Console.ReadLine());
switch (islemTipi)
{
    case '+':
        Console.WriteLine("Sonuç : " + (sayi1 + sayi2));
        break;
    case '-':
        Console.WriteLine("Sonuç : " + (sayi1-sayi2));
        break;
    case '*':
        Console.WriteLine("Sonuç : " + (sayi1 * sayi2));
        break;
    case '/':
        Console.WriteLine("Sonuç : " + (sayi1 / sayi2));
        break;
    default:
        Console.WriteLine("Öyle bir işlem tipi tanımlı değil.");
        break;
}

// Bir ürün için anket yapılıyor.
// Ankette beğenenler , beğenmeyenler , kararsızlar var.
// Bu kişilerin sayılarını ve toplam ankete katılanların sayılarını ekrana yazan bir uygulama.
// Soru -> Beğendiniz mi ? e/h/k
// İlk anket yapıldıktan sonra , başka kullanıcı var mı ? diye sorulacak , e/h cevabına göre , ya soru yeniden sorulacak ya da sonuçlar ekrana yazdırılacak.
// switch-case ile

int begenenler = 0, begenmeyenler = 0, kararsizlar = 0;
soru: Console.WriteLine("Ürünü beğendiniz mi ? (e/h/k)"); // satıra isim verdim.
string fikir = Console.ReadLine();
switch (fikir)
{
    case "e":
        begenenler++;
        break;
    case "h":
        begenmeyenler++;
        break;
    case "k":
        kararsizlar++;
        break;
    default:
        Console.WriteLine("GEÇERSİZ CEVAP!");
        break;
}
varMi: Console.WriteLine("Ankete katılacak başka bir kullanıcı var mı ? (e/h)");
string cevap = Console.ReadLine();
switch (cevap)
{
    case "e":
        goto soru; // ismi soru olan satıra yönlendir.
        break; // altını yeşil çizmesinin nedeni -> bu satıra hiç bir zaman gelinemeyecek olması.
    case "h":
        Console.WriteLine("Beğenenler : " + begenenler);
        Console.WriteLine("Beğenmeyenler : " + begenmeyenler);
        Console.WriteLine("Karasızlar : " + kararsizlar);
        Console.WriteLine("Toplam katılımcı sayısı : " + (begenenler + begenmeyenler + kararsizlar));
        break;
    default:
        Console.WriteLine("Yanlış girdi.");
        goto varMi;
        break;
}