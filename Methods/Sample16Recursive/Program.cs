// 5!
// 5 x 4!
// 5 x 4 x 3!
// 5 x 4 x 3 x 2!
// 5 x 4 x 3 x 2 x 1!
// 5 x 4 x 3 x 2 x 1 x 0!
int FaktoriyelHesapla(int sayi)
{
    if (sayi == 0)
        return 1;
    else
        return sayi * FaktoriyelHesapla(sayi - 1);
}
Console.WriteLine(FaktoriyelHesapla(5));
int sonuc = FaktoriyelHesapla(4);
Console.WriteLine(sonuc);
// Ödev -> FIBONACCI örneğini araştır.