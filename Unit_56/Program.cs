// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int row, int column)
{
    int[,] Array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Array[i, j] = new Random().Next(1, 10);
        }
    }
    return Array;
}


void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)

    {

        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindMinRow(int[,] Array)
{
    int min = 0;
    int SumMinRow = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int summ = 0;
        
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            summ = summ + Array[i, j];
            
        }
        Console.WriteLine($"Сумма строки {i} = {summ}");
        if(i < 1)
        {
            SumMinRow = summ;
        }
        else
        {
            if(SumMinRow > summ)
            {
                SumMinRow = summ;
                min = i;
            }
        }
    }
    return min;
}

int row = 3;
int column = 4;
int[,] NewArray = FillArray(row, column);
PrintArray(NewArray);
Console.WriteLine();
int Rowmin = FindMinRow(NewArray);
Console.WriteLine($"Строка массива с наименьшей суммой элементов - {Rowmin}");
