Console.Clear();

/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
 что такого элемента нет.*/

int rowMean = GetNumberFromUser("Введите номер строки массива: ", "Введено неверное число");
int columnMean = GetNumberFromUser("Введите номер столбца массива: ", "Введено неверное число");

int[,] array = InitArray(5, 5, 0, 10);

PrintArray(array);
PrintMeaningArray(array, rowMean, columnMean);



int[,] InitArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintMeaningArray(int[,] inArray, int m, int n)
{
    if (m > inArray.GetLength(0) || n > inArray.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет.");
    }
    else
    {
        Console.WriteLine();
        Console.Write($"Значение элемента: {inArray[m - 1, n - 1]} ");
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
