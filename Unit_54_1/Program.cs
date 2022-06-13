// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива


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

int[,] SortArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            int count = j+1;
            while (count < Array.GetLength(1))
            {
                if (Array[i, j] < Array[i, count])
                {
                    int temp = Array[i, j];
                    Array[i, j] = Array[i, count];
                    Array[i, count] = temp;
                    count++;
                }
                else
                {
                    count++;
                }
            }
        }
    }
    return Array;
}


int row = 3;
int column = 4;
int[,] NewArray = FillArray(row, column);
PrintArray(NewArray);
Console.WriteLine();
int[,] SortNewArray = SortArray(NewArray);
PrintArray(SortNewArray);