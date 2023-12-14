// FOR ILE
// Ekrana 10 defa " Atatürk'ün Ankara'ya gidişiniz 103.yılı kutlu olsun ! " yazdıran bir for döngüsü.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Atatürk'ün Ankara'ya gidişiniz 103.yılı kutlu olsun !");
}

// Ekrana 1'den 25'e kadar olan sayıları yazdırınız.
for (int i = 1; i <= 25; i++)
{
    Console.WriteLine(i);
}

// Ekrana 1'den 100'e kadar olan çift sayıları yazdırınız. (kontrol yaparak)
for (int i = 1; i <= 100; i++)
{
    if(i % 2 == 0)
        Console.WriteLine(i);
}

// Ekrana 1'den 100'e kadar olan çift sayıları yazdırınız. (kontrol yapmadan)
for (int i = 2; i <= 100; i+=2)
{
    Console.WriteLine(i);
}
// Yukardaki 2 çözüm arasından , 2. daha performanslıdır.
// 50 tur döner , kontrol yapmaz.

// Ekrana 1'den 100'e kadar olan sayıların toplamını yazdıran for döngüsü.
int toplam = 0;
for (int i = 1; i < 101; i++)
{
    toplam = toplam + i;
}
Console.WriteLine(toplam);

// 1 - 1000 arasındaki sayılar
for (int i = 1; i <= 1000; i++)
{
    Console.WriteLine(i);
}

// 1 ile 100 arasındaki sayıların toplamı
int toplam = 0;
for (int i = 1; i <=100 ; i++)
{
    toplam = toplam + i;
}

// 150 ile 355 arası tek sayılar
for (int i = 150; i < 356; i++)
{
    if (i % 2 != 0)
        Console.WriteLine(i);
}