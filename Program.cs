Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for ( int b = 2; b <= a; b++)
{
    if (b % 2 == 0)
    {
    Console.Write ( b + " " );
    }

}