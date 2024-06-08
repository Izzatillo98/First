
int meningYoshim ;
Console.WriteLine("mening Yoshim nechchada");
Console.Write("Yoshiz: ");
string kereliYosh = Console.ReadLine();
meningYoshim = convertToInt32(kereliYosh);
bool aslYoshim = meningYoshim > 20 && meningYoshim < 30;
Console.WriteLine(aslYoshim);