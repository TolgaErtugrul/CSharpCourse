// Parametre olarak aldığı bir metni ekrana yazdıran metot.
void MesajYaz(string metin)
{
    Console.WriteLine(metin);
}
MesajYaz("Buraya metin girdim.");
// Parametre olarak aldığı bir metni , kullanıcının istediği sayıda ekrana yazdıran bir metot.
void MesajYaz2(string metin , int tekrar)
{
    for (int i = 0; i < tekrar; i++)
    {
        Console.WriteLine(metin);
    }
}
MesajYaz2("selam", 3);
// Ekrana "Kapkara gözlerle yaktın sineden" yazan bir metot.
void MesajYaz3()
{
    Console.WriteLine("Kapkara gözlerle yaktın sineden.");
}
MesajYaz3();
// parametre olarak gönderilen 2 değerden hangisinin büyük olduğunu ekrana yazan bir metot.
void BuyukOlaniBul(int sayi1 , int sayi2)
{
    if(sayi1 > sayi2)
        Console.WriteLine(sayi1 +  " büyüktür");
    else
        Console.WriteLine(sayi2 + " büyüktür.");
}
BuyukOlaniBul(5, 10);
BuyukOlaniBul(55, 40);
// parametre olarak gönderilen 2 değerden büyük olanı geriye dönen bir metot.
int BuyukOlaniBul2(int sayi1 , int sayi2)
{
    if (sayi1 > sayi2)
        return sayi1;
    else
        return sayi2;
}
BuyukOlaniBul2(15, 25); // -> karşılığı 25
int geriyeDonen = BuyukOlaniBul2(15, 25);
// int geriyeDonen = 25 demiş gibi oluyorsun.
// parametre olarak alınan değer 10'dan büyük mü yoksa küçük mü bakan , geriye true ya da false bilgisi dönen bir metot.
bool KontrolEt(int sayi)
{
    if (sayi > 10)
        return true;
    else
        return false;
}
KontrolEt(20); // karşılığı --> true
KontrolEt(15); // karşılığı --> true;
KontrolEt(3); // karşılığı --> false;