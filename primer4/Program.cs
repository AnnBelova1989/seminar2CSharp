System.Console.WriteLine( "Введите первое число: ");
int firstnumber= int.Parse(Console.ReadLine());
System.Console.WriteLine( "Введите второе число: ");
int secondnumber= int.Parse(Console.ReadLine());
if(firstnumber%secondnumber==0)
{
    System.Console.WriteLine($"Число {secondnumber} кратно {firstnumber} ");
}
else 
{
    int Mod = firstnumber%secondnumber;
        System.Console.WriteLine($"Число {secondnumber} не кратно {firstnumber} , остаток от деления равен {Mod}");
}

