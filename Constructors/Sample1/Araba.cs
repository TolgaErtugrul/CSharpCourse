namespace ConstructorOrnek1
{
    public class Araba
    {
        public Araba()
        {
            Console.WriteLine("Vınnnnnn");
        }

        public Araba(string marka , string model , string renk , int kapi)
        {
            Console.WriteLine("Vınnnnnnn");
            UretimTarihi = DateTime.Now;
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapi;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }
        public DateTime UretimTarihi { get; set; }
    }
}