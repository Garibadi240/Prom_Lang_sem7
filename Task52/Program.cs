Console.Clear();

/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/

int rows = GetNumberFromUser("Введите номер строки массива: ", "Введено неверное число");
int columns = GetNumberFromUser("Введите номер столбца массива: ", "Введено неверное число");

int[,] array = InitArray(rows, columns, 0, 10);

PrintArray(array);
ArithmeticMeanСolumnArray(array);



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

void ArithmeticMeanСolumnArray(int[,] inArray)
{
    double sum = 0;
    double arMean = 0;

    Console.Write("cреднее арифметическое элементов в каждом столбце: ");

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[j, i];
        }
        arMean = sum / inArray.GetLength(1);
        Console.Write($"{arMean}; ");
        arMean = 0;
        sum = 0;
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
    Console.WriteLine();
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
