int sayi1;
int sayi2;

Console.WriteLine("1. sayıyı giriniz:");
sayi1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1. sayı = "+sayi1);
Console.WriteLine("2. sayıyı giriniz:");
sayi2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.sayı = "+sayi2);

int ort = (sayi1+sayi2)/2;

Console.WriteLine("Ortalama ="+ ort);