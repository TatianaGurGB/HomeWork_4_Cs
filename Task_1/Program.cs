// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

int Number (int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++) 
    {
        result *= A;
    } 
    return result;
}

Console.WriteLine(Number(2,5));