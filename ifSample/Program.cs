//Kullanıcıdan alınan sayının tek mi  çift mi olduğunu geri dönen program
/*
System.Console.WriteLine("Lütfen, sayı giriniz");
int sayi= Convert.ToInt32(Console.ReadLine());

if(sayi%2==0)
    System.Console.WriteLine("Sayı çifttir.");
else
    System.Console.WriteLine("Sayı tektir.");
*/
//ve - veya kullanımı (and - or)
/*
int sayi = 7;
if(sayi%2 ==1 || sayi%2 ==-1) // tek bir koşulun doğru olması yeterli.
    System.Console.WriteLine("Sayı tektir.");
else
    System.Console.WriteLine("Sayı çifttir.");
*/
/*
if(sayi%2==1 && sayi2 ==-1) //tüm koşulların doğru olması gerekli.
    System.Console.WriteLine("Sayı tektir.");
else
    System.Console.WriteLine("Sayı çifttir."); //bu algoritmayı and ile çalıştırmak yanlıştır. Örnek olması için yapılmıştır.
*/

//Kullanıcıdan 3 adet sayı alınız. Bu sayılardan en büyüğünü ve en küçüğünü ekrana yazdırınız.

//int sayi1, sayi2, sayi3;
//sayi1 = Convert.ToInt32(Console.ReadLine());
//sayi2 = Convert.ToInt32(Console.ReadLine());
//sayi3 = Convert.ToInt32(Console.ReadLine());
//1.Yol
/*
if(sayi1 > sayi2 && sayi1 > sayi3)
    System.Console.WriteLine("En büyük -> "+ sayi1);
else if( sayi2 > sayi1 && sayi2 > sayi3)
    System.Console.WriteLine("En büyük -> "+ sayi2);
else
    System.Console.WriteLine("En büyük -> "+ sayi3);
if(sayi1 < sayi2 && sayi1 < sayi3)
    System.Console.WriteLine("En küçük -> "+ sayi1);
else if(sayi2 < sayi1 && sayi2 < sayi3)
    System.Console.WriteLine("En küçük -> "+ sayi2);
else
    System.Console.WriteLine("En küçük -> "+ sayi3);
*/

//2.Yol
/*
int enBuyuk = sayi1;
int enKucuk = sayi1;
if(sayi2 > enBuyuk)
    enBuyuk = sayi2;
if(sayi3 > enBuyuk)
    enBuyuk = sayi3;
if(sayi2 < enKucuk)
    enKucuk = sayi2;
if(sayi3 < enKucuk)
    enKucuk = sayi3;
System.Console.WriteLine("En büyük -> "+ enBuyuk);
System.Console.WriteLine("En küçük -> "+ enKucuk);
*/

//Bilgi yarışması
/*
string cevap;
int puan = 0;
Console.WriteLine("Soru1) Kızınca tüküren hayvan hangisidir?");
Console.WriteLine("a=Lama");
Console.WriteLine("b=Deve");

cevap = Console.ReadLine();

if(cevap == "a" || cevap == "A"){
    puan += 1
    Console.WriteLine("Doğru cevap");
}
else
    Console.WriteLine("Yanlış cevap");

Console.WriteLine("Soru 2) Dünyaya en yakın gezegen hangisidir?");
Console.WriteLine("a) Venüs");
Console.WriteLine("b) Mars");

cevap = Console.ReadLine();

if(cevap == "b" || cevap == "B"){
    puan += 1;
    Console.WriteLine("Doğru cevap");
}
else
    Console.WriteLine("Yanlış cevap");

if(puan != 0){
    Console.WriteLine("Soru 3) 5*2+8/2-2 işleminin sonucu kaçtır?");
    Console.WriteLine("a) 7");
    Console.WriteLine("b) 12");

    cevap = Console.ReadLine();

    if(cevap == "b" || cevap == "B"){
        puan += 1;
        Console.WriteLine("Doğru cevap.");
    }
    else
        Console.WriteLine("Yanlış cevap.");

    Console.WriteLine("Puan -----> "+ puan);

    if(puan >=2)
        Console.WriteLine("Kazandınız.");
    else
        Console.WriteLine("Kaybettiniz.");
}
else
    Console.WriteLine("Yarışmayı kaybettiniz")
*/
