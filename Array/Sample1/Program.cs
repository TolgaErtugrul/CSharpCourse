string[] kisiler = new string[6];

kisiler[0] = "Ajda";
kisiler[1] = "Hande";
kisiler[2] = "Funda";
kisiler[3] = "Ebru";
kisiler[4] = "Gülşen";
kisiler[5] = "Hadise";

// Bir dizinin uzunluğunu bulmak istiyorsak.
// kisiler.Length
Console.WriteLine(kisiler.Length);

// Bir dizinin ilk elemanı 
// kisiler[0]
Console.WriteLine(kisiler[0]);

// Bir dizinin son elemanı
// kisiler[kisiler.length-1]
Console.WriteLine(kisiler[kisiler.Length-1]);

// Bir dizinin elemanlarını yazdırmak.
for (int i = 0; i <= kisiler.Length-1; i++)
{
    Console.WriteLine(kisiler[i]);
}

// Kullanıcıdan alınan verilerle doldurmak isteseydim.
for (int i = 0; i <= kisiler.Length - 1; i++)
{
    kisiler[i] = Console.ReadLine();
}