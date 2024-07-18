int toplam = 0;
int tek = 0;
int cift = 0;
//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
for (int i = 0; i < 10; i++)
{

    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
Console.WriteLine("*******************");
//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
for (int i = 1; i < 21; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("*******************");
//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
for (int i = 0; i < 21; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("*******************");
//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

for (int i = 50; i<= 150; i++)
{
    toplam += i;
}
Console.WriteLine($"Toplam: {toplam}");


Console.WriteLine("*******************");
//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
for (int i = 0;i<=120;i++)
{
    if (i%2 == 0)
    {
        cift+= i;
    }
    else 
    
    {
        tek += i; 
    }
}
Console.WriteLine($"Tek sayılar Toplamı : {tek} \nÇift sayılar toplamı : {cift}");