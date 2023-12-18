// Bir class'ı newlemek = Bir class'tan instance almak = Bir class'tan nesne oluşturmak ---- > Hepsi aynı anlama gelir.
// Constructor
// Bir nesne oluşturulurken otomatik olarak tetiklenen metot. Her class içerisinde bulunur.
using Constructor;
Bebek yeniDogan = new Bebek();
yeniDogan.Ad = "Ada";
yeniDogan.Soyad = "Mada";
yeniDogan.TcNo = "12312313";
yeniDogan.Kilo = 3.5;
// yeniDogan.DogumTarihi = DateTime.Now; bu işlemi constructor'da yapabilirim.
// Bu alandaki bebeğin, ad - soyad - tcno - kilo bilgileri bebek doğduktan sonra atanmış.
Bebek yeniDogan2 = new Bebek("Ahmet", "Mehmet");
Console.WriteLine("Bir bebek oluşturuluyor.");
Bebek yeniDogan3 = new Bebek();
Console.WriteLine("Bebeğinize isim veriniz.");
yeniDogan3.Ad = Console.ReadLine();
Console.WriteLine("Bebeğinize soyisim veriniz.");
yeniDogan3.Soyad = Console.ReadLine();
Console.WriteLine(yeniDogan3.Ad + " " + yeniDogan3.Soyad + " Dünyaya geldi.");
Console.WriteLine("Doğum tarihi : " + yeniDogan3.DogumTarihi);
Console.WriteLine("Bebeğinize ne isim koyacaksınız ?");
string isim = Console.ReadLine();
Console.WriteLine("Soyadisminiz nedir?");
string soyisim = Console.ReadLine();
Bebek yeniDogan4 = new Bebek(isim, soyisim);
Console.WriteLine(yeniDogan4.Ad + " " + yeniDogan4.Soyad + " Dünyaya geldi.");
// Her class'ta constructor olmak zorundadır.
// Constructor ile bir class new'lendiği anda çalışmasını istediğiniz kodları tanımlayabilirsiniz.
// Constuctor olması zorunlu bile olsa , içerisine bir kod yazmak zorunlu değildir, tercihtir.
// Birden fazla, farklı şekilde çalışan consturctor yazılabilir ( ne de olsa constuctor bir metot ) --> Method Overloading