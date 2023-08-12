int VvodChisel(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

bool Multiplisity(int number)
{
    if((number%7==0)&&(number%23==0))
    {
    return true;
    }
    return false;
}
void result(bool mult, int num)
{
    if(mult == true)
    {
            System.Console.WriteLine($"Число {num} кратно числам 7 и 23 одновременно");
    }
    else
    {
         System.Console.WriteLine($"Число {num} не кратно числам 7 и 23 одновременно");   
    }

}
int num =VvodChisel("введите число: ");
bool mult=Multiplisity(num);
result(mult,num);


//System.Console.WriteLine("введите число: ");
//int num = int.Parse(Console.ReadLine());
// if((num%7==0)&&(num%23==0))
// {
//     System.Console.WriteLine($"Число {num} кратно числам 7 и 23 одновременно");
// }
// else
// {
//     System.Console.WriteLine($"Число {num} не кратно числам 7 и 23 одновременно");
// }
