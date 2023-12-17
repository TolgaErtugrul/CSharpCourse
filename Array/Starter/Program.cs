// ARRAY (Dizi)
//int sayi1 = 3;
//int sayi2 = 4;
//int sayi3 = 5;
// şeklinde değişkenler tanımlayabileceğimizi biliyoruz.
// Aynı türde birden fazla değişkeni tanımlamak istiyorsak , dizi kullanabiliriz.
// int[] sayilar = { 3, 4, 5 }; // değerler belliyse

int[] sayilar = new int[3]; // içerisinde 3 adet int değer alabilen bir dizi oluşturuldu, değerler şu an boş.
sayilar[0] = 3;
sayilar[1] = 4;
sayilar[2] = 5;
// sayilar[3] = ... -> patlar ! çünkü öyle bir alan açılmadı.

// Bir gala gecesi için konuk listem var , bu kişilerin isimlerini bir dizide tutalım.

// Ajda
// Hande
// Funda
// Ebru
// Gülşen
// Hadise

string[] kisiler = new string[6];
kisiler[0] = "Ajda";
kisiler[1] = "Hande";
kisiler[2] = "Funda";
kisiler[3] = "Ebru";
kisiler[4] = "Gülşen";
kisiler[5] = "Hadise";