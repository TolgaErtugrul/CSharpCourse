string ornekMetin;
ornekMetin = Console.ReadLine();
// CompareTo
// İki mitni karşılaştırır, sözlük sırasına göre. Aynı lokasyondalarsa 0 , parametredeki değer , ana değerden önceyse -1 , sonraysa +1 döner.
int sonuc = ornekMetin.CompareTo("bilgeadam");
switch (sonuc)
{
    case 0:
        Console.WriteLine("Aynı kelime");
        break;
    case 1:
        Console.WriteLine("Kelime sözlükte daha sonra geliyor.");
        break;
    case -1:
        Console.WriteLine("Kelime sözlükte daha önce geliyor.");
        break;
}
// Contains 
bool varMi = ornekMetin.Contains("Bilge");
Console.WriteLine(varMi == true ? "Metinde geçiyor" : "Metinde geçmiyor.");
//if(varMi == true)
//{
//    Console.WriteLine("metinde geçiyor");
//}
//else
//{
//    Console.WriteLine("metinde geçmiyor.");
//}
// Starts/Ends With
bool basliyorMu = ornekMetin.StartsWith("Bilge");
bool bitiyorMu = ornekMetin.EndsWith("adam");
if(basliyorMu == true)
    Console.WriteLine("Metniniz Bilge ile başlıyor");
else
    Console.WriteLine("Metniniz Bilge ile başlamıyor.");
if(bitiyorMu == true)
    Console.WriteLine("Metniniz adam ile bitiyor.");
else
{
    Console.WriteLine("Metniniz adam ile bitmiyor.");
}
// ToLower() / ToUpper() -> KALICI DEĞİLDİR
Console.WriteLine(ornekMetin.ToUpper());
Console.WriteLine(ornekMetin.ToLower());
ornekMetin = ornekMetin.ToUpper(); // BÖYLE YAPARSAN KALICIDIR.
// Trim() -> baş ve sondaki boşlukları temizler, aradakiler kalır.
Console.WriteLine(ornekMetin.Trim());