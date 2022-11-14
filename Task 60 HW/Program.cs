// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/* Массив размером 2 x 2 x 2 */

void InputMatrix(int[,,] MatrixOne)
{
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixOne.GetLength(1); j++)
        {
            for (int k = 0; k < MatrixOne.GetLength(2); k++)

            MatrixOne[i, j, k] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix(int[,,] MatrixOne)
{
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixOne.GetLength(1); j++)
        {
            for (int k = 0; k < MatrixOne.GetLength(2); k++)
            
            Console.WriteLine(MatrixOne[i,j,k]+ "(" + i + ", " + j + ", " + k + ")");            
            
         }
    }
}


int[,,] MatrixOne = new int[2,2,2];
Console.WriteLine("Массив: ");
InputMatrix(MatrixOne);
PrintMatrix(MatrixOne);
