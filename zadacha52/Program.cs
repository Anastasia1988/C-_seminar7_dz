// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
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
double[] ArithmeticMean(double[,] matrix)
{
    double arithmeticMean = 0;
    
    double[] result = new double[matrix.GetLength(1)];
   
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        arithmeticMean = Math.Round((sum / matrix.GetLength(0)), 3);
        result[j] = arithmeticMean;
    }
    return result;
}
void PrintResult(double[] result)
{    
    for (int j = 0; j < result.Length; j++)
    {
        System.Console.Write($"{result[j] + "; "}");
    }
}

int rows = ReadInt("Введите количество строк матрицы");
int cols = ReadInt("Введите количество столбцов матрицы");

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
double[] myResult = ArithmeticMean(myMatrix);
PrintResult(myResult);



