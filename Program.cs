class Program {
    static void Main() {
        // размер массива
        int m = 4;
        int n = 5;

        // создание двумерного массива
        int[,] matrix = new int[m, n];

        // заполнение массива
        Random random = new Random();
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                matrix[i, j] = random.Next(10);
            }
        }

        // сортировка элементов каждой строки по убыванию
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n - 1; j++) {
                for (int k = j + 1; k < n; k++) {
                    if (matrix[i, k] > matrix[i, j]) {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[i, j];
                        matrix[i, j] = temp;
                    }
                }
            }
        }

        // вывод отсортированного массива на консоль
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}