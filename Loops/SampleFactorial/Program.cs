// Kullanıcıdan öğrenilen bir sayının faktöriyelini hesaplayan uygulama.
// 5! = 5x4x3x2x1 

Console.WriteLine("Faktöriyelini hesaplamak istediğin sayıyı gir.");
int sayi = Convert.ToInt32(Console.ReadLine());
int faktoriyel = 1;
for (int i = 1; i <= sayi; i++)
{
    faktoriyel *= i;
}
Console.WriteLine("Sonuç : " +faktoriyel);