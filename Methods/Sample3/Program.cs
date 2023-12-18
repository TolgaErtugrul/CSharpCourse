// Parametre olarak alınan isim ve soyisim bilgisiyle "Hoş geldin .... ..... " şeklinde bir mesaj dönen metot.
string SelamVer(string isim, string soyisim)
{
    return "Hoş Geldin " + isim + " " + soyisim;
}
Console.WriteLine("Adınız nedir ?");
string isim = Console.ReadLine();
Console.WriteLine("Soyadınız nedir?");
string soyisim = Console.ReadLine();
string mesaj = SelamVer(isim, soyisim); // çağırırken parametre tipi yazılmaz.
Console.WriteLine(mesaj);
// Parametre almayan metot da olabilir.
string Selam()
{
    return "Selam";
}
Console.WriteLine(Selam());