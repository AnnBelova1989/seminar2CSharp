int VvodChisel(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

bool Multiplisity(int number)
{
    return number%7==0 && number%23==0;
  
}

int num =VvodChisel("введите число: ");
bool mult=Multiplisity(num);
string result =mult ? $"Число {num} кратно числам 7 и 23 одновременно" : $"Число {num} не кратно числам 7 и 23 одновременно";
System.Console.WriteLine(result);



