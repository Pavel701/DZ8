class Program
{
    static void Main(string[] args)
    {
        // Инициализация двумерного массива
        int[,] array = {
            { 1, 4, 7, 2},
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        // Получение размеров массива
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Упорядочивание элементов каждой строки
        for (int i = 0; i < rows; i++)
        {
            // Сортировка текущей строки по убыванию
            SortRowDescending(array, i, cols);
        }

        // Вывод упорядоченного массива
        Console.WriteLine("Упорядоченный массив:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Метод для сортировки элементов строки по убыванию
    static void SortRowDescending(int[,] array, int row, int cols)
    {
        for (int i = 0; i < cols - 1; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                if (array[row, i] < array[row, j])
                {
                    // Обмен элементов местами
                    int temp = array[row, i];
                    array[row, i] = array[row, j];
                    array[row, j] = temp;
                }
            }
        }
    }
}
