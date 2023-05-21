// class Program
// {
//     static void Main(string[] args)
//     {
//         // Инициализация  массива
//         int[,] array = {
//             { 1, 4, 7, 2},
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 }
//         };

        
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

        
//         for (int i = 0; i < rows; i++)
//         {
//             // Сортировка строки по убыванию
//             SortRowDescending(array, i, cols);
//         }

//         // Вывод упорядоченного массива
//         Console.WriteLine("Упорядоченный массив:");

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     // Метод для сортировки
//     static void SortRowDescending(int[,] array, int row, int cols)
//     {
//         for (int i = 0; i < cols - 1; i++)
//         {
//             for (int j = i + 1; j < cols; j++)
//             {
//                 if (array[row, i] < array[row, j])
//                 {
//                     // Обмен элементов местами
//                     int temp = array[row, i];
//                     array[row, i] = array[row, j];
//                     array[row, j] = temp;
//                 }
//             }
//         }
//     }
// }

///////////////////////////////////////////////////////////////////////

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Инициализация прямоугольного двумерного массива
//         int[,] array = {
//             {1, 4, 7, 2 },
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 },
//             { 5, 2, 6, 7 }
//         };

//         // Размер массива
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

//         int minSum = int.MaxValue; 
//         int minSumRow = -1; 

//         for (int i = 0; i < rows; i++)
//         {
//             int sum = 0; 

//             for (int j = 0; j < cols; j++)
//             {
//                 sum += array[i, j];
//             }

//             if (sum < minSum)
//             {
//                 minSum = sum;
//                 minSumRow = i;
//             }
//         }

//         // Вывод строки с наименьшей суммой элементов
//         Console.WriteLine("Строка с наименьшей суммой элементов: ");

//         for (int j = 0; j < cols; j++)
//         {
//             Console.Write(array[minSumRow, j] + " ");
//         }

//         Console.WriteLine();
//     }
// }
///////////////////////////////////////////////////////////////////////////////////

class Program
{
    static void Main(string[] args)
    {
        // Инициализация первой матрицы
        int[,] matrix1 = {
            { 2, 4 },
            { 3, 2 }
        };

        // Инициализация второй матрицы
        int[,] matrix2 = {
            { 3, 4 },
            { 3, 3 }
        };

        // Размер матрицы
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Проверка умножения
        if (cols1 != rows2)
        {
            Console.WriteLine("Невозможно выполнить умножение матриц.");
            return;
        }

        
        int[,] result = new int[rows1, cols2];

        // Произведение матриц
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;

                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                result[i, j] = sum;
            }
        }

        // Вывод результирующей матрицы
        Console.WriteLine("Результирующая матрица:");

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(result[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
