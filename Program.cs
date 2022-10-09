//Задача 47: Задайте двумерный массив размером mxn, заполненный случайными вещественными числами, округленными до одного знака.

void Zadacha47()
{
    Random random = new Random();
    int rows = random.Next(2,5);
    int columns = random.Next(5,8);
    double [,] numbers = new double [rows,columns];
    FillArray(numbers);
    PrintArray(numbers);

}
void FillArray(double [,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i,j] = Math.Round(random.NextDouble() * 20, 1);
        }
    }
}
void PrintArray(double [,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i,j] + "  ");
        }
        Console.WriteLine();
    }
}
Zadacha47();

//Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве и возвращает значение этого элемента или же указание, что такого элемента нет.
 
 void Zadacha50()
 {
    Random random = new Random();
    int rows = random.Next(4,7);
    int columns = random.Next(4,7);
    double [,] numbers = new double [rows,columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Введите индекс строки элемента в массиве");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца элемента в массиве");
    int j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(numbers[i,j]);
 }
 Zadacha50();