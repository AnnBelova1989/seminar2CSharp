int num = new Random().Next(10, 100);
int firstnum = num/10;
int secondnum = num % 10;
int max = firstnum;
if(secondnum>firstnum)
{
max=secondnum;
}
System.Console.WriteLine($"наибольшая цифра числа {num} = {max} ");