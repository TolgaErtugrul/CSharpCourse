// Kullanıcıdan alınan bir metni , yine kullanıcıdan alınan tekrar sayısınca ekrana yazdıran While ve Do-While döngülerini yazınız.

Console.WriteLine("Metin : ");
string metin = Console.ReadLine();
Console.WriteLine("Tekrar Sayısı : ");
int tekrarSayisi = Convert.ToInt32(Console.ReadLine());
// WHILE
int i = 0;
while (i < tekrarSayisi)
{
    Console.WriteLine(metin);
    i++;
}
Console.WriteLine("-----------------------------");
// DO-WHILE
i = 0;
do
{
    Console.WriteLine(metin);
    i++;
} while (i<tekrarSayisi);
// WHILE -> Koşul sağlanıyorsa scope arası komutları çalıştırır.
// DO-WHILE -> Do komutlarını çalıştırır , koşul sağlanıyorsa bir daha çalıştırır.