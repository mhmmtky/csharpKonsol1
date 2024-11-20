string ad;
string soyAd;
int ogNo;
double telNo;        //System.OverflowException: Value was either too large or too small for an Int32 değişkeni int olarak atadığımda bu hatayı aldığım için double ile atadım hocam.
                    

Console.WriteLine("İsminizi Giriniz:");
ad = Console.ReadLine();
Console.WriteLine("Soy İsminizi Giriniz");
soyAd = Console.ReadLine();
Console.WriteLine("Öğrenci Numaranızı Giriniz");
ogNo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Telefon Numaranızı Giriniz");
telNo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İsim Soyisminiz : "+ad + " " + soyAd);
Console.WriteLine("Öğrenci Numaranız : "+ ogNo);
Console.WriteLine("Telefon Numaranız : "+ telNo);
