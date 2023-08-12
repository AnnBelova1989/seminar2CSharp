int VvodChisel(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

bool result(int number1, int number2)
{
    return number1==number2*number2 || number2==number1*number1;
}
int numb1= VvodChisel("Введите первое число: ");
int numb2= VvodChisel("Введите второе число: ");
bool Itog= result(numb1,numb2); 
string Res = Itog ? "Одно число является квадратом второго": "Одно число не является квадратом второго";
System.Console.WriteLine(Res);

// System.Console.WriteLine("Введите первое число: ");
// int num1= int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int num2= int.Parse(Console.ReadLine());
// System.Console.WriteLine(if(num1==num2*num2 || num2==num1*num1)
// {
//     System.Console.WriteLine("Одно число является квадратом второго");
// }
// else
// {
//     System.Console.WriteLine("Одно число не является квадратом второго");
// );
