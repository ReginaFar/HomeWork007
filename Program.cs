//Задача 47: Задайте двумерный массив размером mxn, заполненный случайными вещественными числами, округленными до одного знака.

void Zadacha47()
{
    Random random = new Random();
    int rows = random.Next(2, 5);
    int columns = random.Next(5, 8);
    double[,] numbers = new double[rows, columns];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);

}
void FillArrayDouble(double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(random.NextDouble() * 20, 1);
        }
    }
}
void PrintArrayDouble(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Zadacha47();

//Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве и возвращает значение этого элемента или же указание, что такого элемента нет.

void Zadacha50()
{
    Random random = new Random();
    int [,] numbers = new int[3,5];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Введите индекс строки элемента в массиве");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца элемента в массиве");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i > numbers.GetLength(0) || j > numbers.GetLength(1))
    {
        Console.WriteLine($"{i};{j} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(numbers[i,j]);
    }
    Console.WriteLine();
}
Zadacha50();

//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(2, 5);
    int columns = random.Next(5, 8);
    int [,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    FindArithmeticMean(numbers);
}
void FillArray(int [,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0,10);
        }
    }
}
void PrintArray(int [,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FindArithmeticMean(int [,] numbers)
{   
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    double average = 0;
    double sum = 0;
    for (int j = 0; j < columns; j++)
    {
    for (int i = 0; i < rows; i++)
        {
        sum = sum + numbers[i,j];
        }
        average = sum / rows;
        Console.WriteLine("Среднее арифметическое =" + average);
        sum = 0;
    }
}
Zadacha52();

