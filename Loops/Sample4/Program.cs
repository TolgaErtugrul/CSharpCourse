// Hem While , hem Do-While ile
// Kullanıcıdan sürekli sayı isteyen , kullanıcı 0 girdiğinde duran bir program.
// WHILE
int sayi;
while (true)
{   
    Console.WriteLine("Sayı giriniz.");
    sayi = int.Parse(Console.ReadLine()); // convert işlemi ile aynı

    if (sayi == 0)
        break;
}
Console.WriteLine("------------------------------------");
// DO-WHILE
do
{
    Console.WriteLine("Sayı giriniz");
    sayi = int.Parse(Console.ReadLine());
} while (sayi != 0);