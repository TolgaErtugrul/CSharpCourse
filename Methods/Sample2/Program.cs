// Parametre olarak aldığı sayının 5'e bölümünden kalanı geri dönen bir metot.
int BolumundenKalan(int sayi)
{
    int kalan = sayi % 5;
    return kalan;
    // return sayi % 5; de yazılabilir.
}
int x = BolumundenKalan(5);
Console.WriteLine(x);