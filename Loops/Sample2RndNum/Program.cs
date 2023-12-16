// 1 ile 10 arasında rastgele bir sayıyı kaçıncı tahminde bildiğimizi bize söyleyen bir program.
// Bir döngüden break; komutuyla çıkabilirsiniz.

Random rnd = new Random();
int rastgele = rnd.Next(1, 11); // 11 dahil değil.
Console.WriteLine("------------------------------- " + rastgele ); // test amaçlı , üretilen rastgele sayıyı ben bileyim diye.

int tahminSayisi = 0;
while (true) // sonsuz döngü
{
    Console.WriteLine("1 ile 10 arasında tahmininizi giriniz.");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    tahminSayisi++;
    if(tahmin == rastgele)
    {
        break;
    }
}
Console.WriteLine(tahminSayisi + ". tahminde bildiniz.");