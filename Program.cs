double sayi = 0;
Console.Write("Sayı giriniz:");
sayi = Convert.ToDouble(Console.ReadLine());
double kalan = sayi % 2;

if (kalan == 0)
{
    Console.Write("Girdiğiniz sayı ÇİFT'tir.");
}
else
{
    Console.Write("Girdiğiniz sayı TEK'tir.");
}
Console.ReadKey();