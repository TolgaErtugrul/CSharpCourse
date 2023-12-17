// Dizi : { 60 , 80 , 55 , 42 , 13 , 24 , 26 , 25 , 26 , 55 , 45 , 50 , 50 , 40 }
// Kullanıcının girmiş olduğu bir sayının dizide olup olmadığını bulan, varsa kaç adet olduğunu yazdıran bir uygulama.
int[] sayilar = { 60, 80, 55, 42, 13, 24, 26, 25, 26, 55, 45, 50, 50, 40 };
Console.WriteLine("Sorgulamak istediğiniz sayıyı yazınız.");
int sorgu = Convert.ToInt32(Console.ReadLine());
int sayac = 0;
foreach (var sayi in sayilar)
{
    if (sorgu == sayi)
        sayac++;
}
if(sayac == 0)
    Console.WriteLine("Bu sayıdan dizide yok!");
else
    Console.WriteLine("Bu sayıdan dizide " + sayac + " tane var!");