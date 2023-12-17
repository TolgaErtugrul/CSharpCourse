// Kullanıcı tarafından belirsiz sayıda girilen sayılardan tek olanları küçükten büyüğe , çift olanları büyükten küçüğe ekrana yazdıran bir program.
// Kullanıcıdan sayı alınınca , kullanıcıya soralım : " Başka sayı girmek istiyor musunuz ? (e/h)
// e demesi durumunda , yeni sayı alınsın;
// h demesi durumunda, sonuçlar ekrana yazdırılsın.
// e/h büyük-küçük harf duyarlı olmasın.
// * advanced -> kullanıcı aynı sayıyı bir daha giremesin.
// yazılan her işleme bir komut satırı ekleyelim tamamlanınca.
int[] tekSayilar = new int[0];
int[] ciftSayilar = new int[0];
string cevap;
do
{
sayiGir: Console.WriteLine("Sayı giriniz.");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 2 == 0)
    {
        if (Array.IndexOf(ciftSayilar, sayi) == -1)
        {
            Array.Resize(ref ciftSayilar, ciftSayilar.Length + 1);
            ciftSayilar[ciftSayilar.Length - 1] = sayi;
        }
        else
        {
            Console.WriteLine("Sayı dizide mevcut , yeniden eklenmeyecek.");
            goto sayiGir;
        }
    }
    else
    {
        if (Array.IndexOf(tekSayilar, sayi) == -1)
        {
            Array.Resize(ref tekSayilar, tekSayilar.Length + 1);
            tekSayilar[tekSayilar.Length - 1] = sayi;
        }
        else
        {
            Console.WriteLine("Sayı dizide mevcut , yeniden eklenmeyecek.");
            goto sayiGir;
        }
    }
    Console.WriteLine("Başka sayı girmek istiyor musunuz ? (e/h)");
    cevap = Console.ReadLine();
} while (cevap.ToLower() == "e");
Array.Sort(tekSayilar); // küçükten büyüğe sırala
Array.Sort(ciftSayilar); // küçükten büyüğe sırala
Array.Reverse(ciftSayilar); // ters çevir
// büyükten küçüğe sıralanmış oldu.
Console.WriteLine("TEK SAYILAR");
foreach (var tek in tekSayilar)
{
    Console.WriteLine(tek);
}
Console.WriteLine("ÇİFT SAYILAR");
foreach (var cift in ciftSayilar)
{
    Console.WriteLine(cift);
}