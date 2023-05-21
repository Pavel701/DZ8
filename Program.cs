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

class Program
{
    static void Main(string[] args)
    {
        // Инициализация прямоугольного двумерного массива
        int[,] array = {
            {1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        // Получение размеров массива
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Поиск строки с наименьшей суммой элементов
        int minSum = int.MaxValue; // Начальное значение минимальной суммы
        int minSumRow = -1; // Индекс строки с наименьшей суммой

        for (int i = 0; i < rows; i++)
        {
            int sum = 0; // Сумма элементов текущей строки

            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        // Вывод строки с наименьшей суммой элементов
        Console.WriteLine("Строка с наименьшей суммой элементов: ");

        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[minSumRow, j] + " ");
        }

        Console.WriteLine();
    }
}
