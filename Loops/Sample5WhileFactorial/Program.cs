// While ile faktoriyel hesaplama örneği
// 5! = 5x4x3x2x1
Console.WriteLine("Bir sayı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());
int faktoriyel = 1;
while (sayi > 0)
{
    faktoriyel *= sayi;
    sayi--;
}

Console.WriteLine("Faktöriyel : " + faktoriyel);