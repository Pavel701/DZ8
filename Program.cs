int[,] myArray = { {1, 4, 7, 2}, { 5, 9, 2, 3 }, {8, 4, 2, 4} };
Console.WriteLine("Упорядоченный массив:");

for (int i = 0; i < myArray.GetLength(0); i++) {
    for (int j = 0; j < myArray.GetLength(1); j++) {
        for (int k = j + 1; k < myArray.GetLength(1); k++) {
            if (myArray[i, j] < myArray[i, k]) {
                int temp = myArray[i, j];
                myArray[i, j] = myArray[i, k];
                myArray[i, k] = temp;
            }
        }
    }
}

// Вывод упорядоченного массива
for (int i = 0; i < myArray.GetLength(0); i++) {
    for (int j = 0; j < myArray.GetLength(1); j++) {
        Console.Write(myArray[i, j] + " ");
    }
    
    Console.WriteLine();
}
/////////////////////////////////////////////////////////////////////////////////////////////////

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

        // Размер массива
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minSum = int.MaxValue; 
        int minSumRow = -1; 

        for (int i = 0; i < rows; i++)
        {
            int sum = 0; 

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
///////////////////////////////////////////////////////////////////////////////////////////////////////

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
/////////////////////////////////////////////////////////////////////////////////////////////////////////

class Program
{
    static void Main(string[] args)
    {
        // Формирование трехмерного массива размером 2 x 2 x 2
        int[,,] array = new int[2, 2, 2];
        int number = 10; 

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = number++;
                }
            }
        }

        // Вывод  массива 
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine($"Элемент ({i}, {j}, {k}): {array[i, j, k]}");
                }
            }
        }
    }
}
/////////////////////////////////////////////////////////////////////////////////////////////////

int[,] myArray = new int[4, 4];
//Индекс текущей строки, индекс текущего столбца и текущее значение элемента
int indexRow = 0;
int indexColumn = 0;
int elementValue = 1;

while (elementValue <= myArray.Length)
{
    // Заполняем верхнюю строку слева направо.
    for (int i = indexColumn; i < myArray.GetLength(1) - indexColumn; i++)
    {
        myArray[indexRow, i] = elementValue;
        elementValue++;
    }
    // Заполняем правый столбец сверху вниз.
    for (int i = indexRow + 1; i < myArray.GetLength(0) - indexRow; i++)
    {
        myArray[i, myArray.GetLength(1) - indexColumn - 1] = elementValue;
        elementValue++;
    }
    // Заполняем нижнюю строку справа налево.
    for (int i = myArray.GetLength(1) - indexColumn - 2; i >= indexColumn; i--)
    {
        myArray[myArray.GetLength(0) - indexRow - 1, i] = elementValue;
        elementValue++;
    }
    // Заполняем левый столбец снизу вверх.
    for (int i = myArray.GetLength(0) - indexRow - 2; i > indexRow; i--)
    {
        myArray[i, indexColumn] = elementValue;
        elementValue++;
    }
    // Переходим к следующей круговой области.
    indexRow++;
    indexColumn++;
}

// Выводим матрицу на экран.
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i, j] + " ");
    }
    Console.WriteLine();
}

