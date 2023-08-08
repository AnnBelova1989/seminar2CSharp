int VvodChisel(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
bool Multiplisity(int num1, int num2)
{
    if(num1 % num2 == 0)
    {
        return true;
    }
    return false;
}
int firstnum = VvodChisel("Введите первое число: ");
int secondnum = VvodChisel("Введите второе число: ");
bool result = Multiplisity(firstnum, secondnum);
if(result == true)
{
    System.Console.WriteLine($"Число {secondnum} кратно {firstnum} ");
}
else
{
    System.Console.WriteLine($"Число {secondnum} не кратно {firstnum} , остаток от деления равен {firstnum % secondnum}");
}