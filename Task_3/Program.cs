// Напишите программу, которая задаёт массив из 8 элементов случайными числами и 
// выводит их на экран. Оформите заполнение массива и вывод 
// в виде функции (пригодится в следующих задачах)

int [] array = new int[8];
for (int i = 0; i < 8; i++)
{

   array[i] = new Random().Next(15);
   Console.WriteLine(array[i]);
}