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