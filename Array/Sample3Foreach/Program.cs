// Foreach
string[] ogrenciler = new string[3];
ogrenciler[0] = "Ajda";
ogrenciler[1] = "Hande";
ogrenciler[2] = "Funda";
// Değer okuma
foreach (var ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}
// Döngünün eleman sayısı kadar döner , her turda ogrenci dediği aslında ogrenciler[i] olarak düşünülebilir.
// 4 elemanlı bir dizi oluşturup , kullanıcıdan bu 4 elemanı atamasını isteyelim (for ile)
string[] dizi = new string[4];
Console.WriteLine("4 eleman giriniz.");
for (int i = 0; i < dizi.Length; i++)
{
    dizi[i] = Console.ReadLine();
}
// Bu 4 elemanı ekrana yazdıralım (foreach).
foreach (var item in dizi)
{
    Console.WriteLine(item);
}