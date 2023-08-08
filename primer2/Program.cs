int MaxDigit(int num)
{
    int firstnum = num / 10;
    int secondnum = num % 10;
    int max = firstnum;
    if (secondnum > firstnum)
    {
        max = secondnum;
    }
    return max;
}
int numb = new Random().Next(10, 100);
int maxDigit = MaxDigit(numbb);
System.Console.WriteLine($"наибольшая цифра числа {numb} = {maxDigit} ");