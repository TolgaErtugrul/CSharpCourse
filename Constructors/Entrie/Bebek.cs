namespace Constructor
{
    public class Bebek
    {
        // Geriye dönüş tipi olmayan ( void bile değil ) , Class ile aynı isimde olmak zorunda olan bir metot -> Constructor (yapıcı metot)
        public Bebek()
        {
            Console.WriteLine("ingaaaaaaaaaa");
            DogumTarihi = DateTime.Now;
        }
        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = DateTime.Now;
            // Değerleri parametre olarak new'leme aşamasında alıp atıyor.
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Kilo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TcNo { get; set; }

    }
}