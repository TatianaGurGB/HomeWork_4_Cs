// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int A (int a)
{
    int result = 0;
    while (a / 10 > 0)
    {
        result = result + a % 10;
        a = a / 10;
    }
    return result + a;
}
Console.WriteLine (A(223));