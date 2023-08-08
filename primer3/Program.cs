int Twonum(int num)
{
    return num/100*10+num%10;
}
int num = new Random().Next(100,1000);
int twonum= Twonum(num);
System.Console.WriteLine($"трехзначное число {num} ");
System.Console.WriteLine($"число без второй цифры {twonum}");
