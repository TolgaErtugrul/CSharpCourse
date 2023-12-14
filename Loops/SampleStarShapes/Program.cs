// Kullanıcının girdiği uzunluktaki bir üçgeni * 'lar ile oluşturan bir konsol uygulaması yazınız.
/*
*
**
***

*
**
***
****
*****
*/

int sayi = Convert.ToInt32(Console.ReadLine());
string yildiz = "*";
for (int i = 1; i <= sayi; i++)
{
    Console.WriteLine(yildiz);
    yildiz = yildiz + "*";
}

// Aşağıdaki şekli oluşturan kodlar
/*
* * * * *
* * * * *
* * * * *
* * * * *
Kullanıcının girdiği satır sayısınca
*/
string yildiz2 = "* * * * *";
Console.WriteLine("Oluşturmak istediğiniz dörtgen kaç satır uzunluğunda olsun ?");
int satirSayisi = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= satirSayisi; i++)
{
    Console.WriteLine(yildiz2);
}