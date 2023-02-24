// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными
//  вещественными числами.
//  m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double[,] GenerateMatrix(double rows, double cols)
{
    Random rand = new Random();
    double[,] matrix = new double[(int)rows, (int)cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble(), 3);
            
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

var rows = ReadInt("Введите количество строк матрицы");
var cols = ReadInt("Введите количество столбцов матрицы");

var myMatrix = GenerateMatrix(rows,cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();


