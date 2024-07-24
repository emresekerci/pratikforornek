for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
Console.WriteLine("---------------------------------------------------------------------------");

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------------------------------------------------------------------------");

for (int i = 2; i <= 20; i += 2)
{

    Console.WriteLine(i);
}
Console.WriteLine("---------------------------------------------------------------------------");

int toplam = 0; //Toplamı saklaması için değişken oluşturuyoruz.

for (int i = 50; i <= 150; i++)
{
    toplam += i;

}
Console.WriteLine("Toplam ---> " + toplam);

Console.WriteLine("---------------------------------------------------------------------------");

int tekSayiToplam = 0;
int ciftSayiToplam = 0;
for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    { ciftSayiToplam += i; }


    else
    {
        tekSayiToplam += i;
    }
}
Console.WriteLine("Çift sayıların toplamı -----> " + ciftSayiToplam);
Console.WriteLine("Tek sayıların toplamı -----> " + tekSayiToplam);

Console.WriteLine("---------------------------------------------------------------------------");