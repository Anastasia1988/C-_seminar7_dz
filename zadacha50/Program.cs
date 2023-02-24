// Задача 50: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int PozElements(int[,] matrix, int pozI, int pozJ)
{
    int element = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (pozI < matrix.GetLength(0) && pozJ < matrix.GetLength(1))
            {
                element = matrix[pozI, pozJ];
                break;
            }
            else
            {
                Console.WriteLine($"Заданной позиции в массиве не существует:[{pozI};{pozJ}]");
            }
        }
    }
    return element;
}
void PrintPozElements(int[,] matrix)
{
    int pozI = new int();
    int pozJ = new int();
    Console.Write($" На заданной позиции находится элемент: {matrix[pozI, pozJ]}");
}

int rows = ReadInt("Введите количество строк матрицы");
int cols = ReadInt("Введите количество столбцов матрицы");
int pozI = ReadInt("Введите позицию элемента в строке матрицы");
int pozJ = ReadInt("Введите позицию элемента в столбце матрицы");
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
var myPoz = PozElements(myMatrix, pozI, pozJ);
PrintPozElements(myMatrix);


