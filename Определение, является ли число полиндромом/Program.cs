// Программа определяет, является ли число полиндромом
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number/10000 > 0)
{
    int i = number/10000;
    int N = number%10;
    if (i == N)
    {
        i = number/1000;
        N = number%100;
        int i1 = i%10;
        int N1 = N/10;
        if(i1 == N1)
        {
           Console.WriteLine("Число является полиндромом"); 
        }
        else Console.WriteLine("Число не является полиндромом во 2 и 4 значении чисел");
    }
    else {Console.WriteLine("Число не является полиндромом");}
}
else {Console.WriteLine("Введите правильное число: положительное, не начинается с 0");}

