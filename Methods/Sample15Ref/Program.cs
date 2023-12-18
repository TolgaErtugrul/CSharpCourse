void NoRefName(string name)
{
    name = "Muhittin";
    Console.WriteLine("BURASI METODUN İÇİ : " + name);
}
void RefName(ref string name)
{
    name = "Melisa";
    Console.WriteLine("BURASI METODUN İÇİ : " + name);
}
Console.Write("İsim : ");
string isim = Console.ReadLine();
NoRefName(isim);
Console.WriteLine("BURASI METODUN DIŞI : " + isim);
RefName(ref isim);
Console.WriteLine("BIRASI METODUN DIŞI : " + isim );
// ref kullanılmazsa , işlemler değişkenin bir kopyası üzerinden gerçekleşir.
// ref kullanılırsa, direkt değişkene etki eder. Kalıcıdır!