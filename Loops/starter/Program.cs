// Aynı kod satırlarını tekrar tekrar yazmak istemiyorsak , döngülere başvururuz.

// While
int sayac = 0;
while (sayac < 3)
{
    Console.WriteLine("Merhaba");
    sayac++;
} // bu noktaya geldiğinde , yeniden kontrol yapar , doğruysa while içerisindeki kodları bir kez daha çalıştırır.

// Do-While
sayac = 0; // sayacı yeni döngü için sıfırladım.
do
{
    Console.WriteLine("Merhaba");
    sayac++;
} while (sayac < 3);

// For
// sayac i olarak isimlendirilmiş
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Merhaba");
}