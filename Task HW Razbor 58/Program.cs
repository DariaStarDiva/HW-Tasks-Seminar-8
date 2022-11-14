// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 11);
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}

void ProizvMetrixs (int[ , ] MatrixOne, int[ , ] MatrixTwo)
{
    Console.WriteLine();
    int [,] ResultMatrix = new int [MatrixOne.GetLength(0), MatrixOne.GetLength(1)];
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
   {
        for (int j = 0; j < MatrixOne.GetLength(1); j++)
        {
            ResultMatrix[i,j] = MatrixOne[i,j] * MatrixTwo[i,j];
            Console.Write($"{ResultMatrix[i,j]} \t");
           
        }
        Console.WriteLine();
   }
}      

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] MatrixOne = new int[n, m];
int[,] MatrixTwo = new int[n, m];
Console.WriteLine("Массив 1: ");
InputMatrix(MatrixOne);
Console.WriteLine("Массив 2: ");
InputMatrix(MatrixTwo);
Console.WriteLine("Массив 3 -Произведение массивов : ");
ProizvMetrixs (MatrixOne, MatrixTwo);
