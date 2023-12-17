// Eleman sayısını kullanıcının belirlediği bir dizi oluşturuz.
Console.WriteLine("Kaç elemanlı dizi oluşturmak istiyorsunuz ?");
int elemanSayisi = Convert.ToInt32(Console.ReadLine());
string[] ogrenciler = new string[elemanSayisi];
// Kullanıcıdan diziyi doldurmasını isteyelim. Kaç elemanlı bir dizi girdiyse o kadar sayıda console.readline() çalışsın ve veriler atansın.
for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.Write((i+1) + ". Öğrenci : ");
    ogrenciler[i] = Console.ReadLine();
}
Console.WriteLine("Öğrenci Bilgileri Başarıyla Alındı.");
// Diziyi ekrana yazdıralım.
Console.WriteLine("----ÖĞRENCİLER----");
for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
// Dizinin ilk elemanını yazdırınız.
Console.WriteLine("Dizinin ilk elemanı : " + ogrenciler[0]);
// Dizinin son elemanını yazdırınız.
Console.WriteLine("Dizinin son elemanı : " + ogrenciler[ogrenciler.Length-1]);