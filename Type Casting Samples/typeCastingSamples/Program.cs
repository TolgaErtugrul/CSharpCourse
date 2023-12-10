///Kullanıcıdan alınan 2 tane float değer arasında, dört işlem yapıp, sonuçları ekrana yazdıran bir program yazalım.
/*
float sayi1, sayi2;
System.Console.WriteLine("Lütfen 1. Sayıyı giriniz.");
sayi1 = Convert.ToSingle(Console.ReadLine());

System.Console.WriteLine("Lütfen 2. sayıyı giriniz.");
sayi2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Sayıların toplamı = "+ (sayi1 + sayi2));
System.Console.WriteLine("Sayıların farkı = "+ (sayi1 - sayi2));
System.Console.WriteLine("Sayıların çarpımı10 = "+ (sayi1 * sayi2));
System.Console.WriteLine("Sayıların bölümü = "+ (sayi1 / sayi2));
*/

//Yarıçapı kullanıcı tarafından verilen bir dairenin alanını hesaplayan program

const double piSayisi = 3.14;
//const keywordü ile, değişkenin değerini sabitliyorum.

System.Console.WriteLine("Yarıçap giriniz.");
double yaricap = Convert.ToDouble(Console.ReadLine());

double alan = piSayisi * Math.Pow(yaricap,2);
System.Console.WriteLine("Dairenin alanı : "+ alan);