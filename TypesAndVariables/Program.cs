
using System.ComponentModel;

short number1 = 9;
int number2 = 67;
var number3 = 'A';


string[,] regions = new string[5, 3]
{
    {"İstanbul","Kocaeli","Balıkesir" },
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Adana","Mersin" },
    {"Rize","Trabzon","Samsun" },
    {"İzmir","Muğla","Aydın" },


};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("********");


}


Console.WriteLine("Bir sayı giriniz:");

String sayi=Console.ReadLine();

int number=Convert.ToInt32(sayi);
bool  asalmi = true;


    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {

            asalmi = false;
        break;
            
        }


        else
        {
            asalmi = true;
        }

    }
    if (asalmi == false && number!=2)
    {
        Console.WriteLine("Sayı asal değildir");
    }


    else
    {
        Console.WriteLine("Sayı asaldır");
    }


enum Gunler
{
    Pazartesi = 10, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar

}






