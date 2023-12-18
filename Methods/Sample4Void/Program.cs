// Return kısmı bulunmayan , yani geriye bir değer dönmeyen metotlardır.
// Kullanıcının verdiğim verdiği mesajı ekrana yazdıran metot.
void EkranaYaz(string mesaj)
{
    Console.WriteLine(mesaj);
}
EkranaYaz("Ben bir metodum");
EkranaYaz("Merhaba");
EkranaYaz("Buraya bakarlar.");
// Örnek - > ekrana "Kimler geldi , kimler geçti yazan bir metot." 
// metot adı -> MesajYaz
void MesajYaz()
{
    Console.WriteLine("Kimler geldi , kimler geçti.");
}
MesajYaz();
MesajYaz();
// Örnek -> Parametre olarak aldığı sayıyı , "Bana gönderilen sayı : ... " şeklinde 3 kere ekrana yazdıran metot.
void GonderilenSayiYaz(int x)
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Bana gönderilen sayı : " + x);
    }
}
GonderilenSayiYaz(12);