//While Loop
int i = 1;
while(i <= 5)
{
    Console.WriteLine(i);
    i++;
}

// Ekrana 10 kere " Yetmedi mi " yazan bir döngü.
int i = 1;
while (i<=10)
{
    Console.WriteLine(" Yetmedi mi ");
    i++;
}

// 0 ile 100 arasındaki sayıların toplamını yazan döngü
int toplam = 0;
int j = 0;
while (j <= 100)
{
    toplam = toplam + j;
    j++;
}
Console.WriteLine("TOPLAM : " + toplam);

//do while Loop
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 5);