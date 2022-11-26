// See https://aka.ms/new-console-template for more information
void Zadacha23()
{
Console.WriteLine ("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;
while (number <= N)
    {
    Console.WriteLine (Math.Pow(number, 3));
    number++;
    }
}
Zadacha23();

