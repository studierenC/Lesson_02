namespace Matrix;

class Program
{
    static void Main()
    {
        int rows = 5, columns = 10;
        var randomArray = GetRandomArray(rows, columns);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{randomArray[i,j]}\t");
            }
            Console.WriteLine();
        }
    }

    static int[,] GetRandomArray(int rows, int columns)
    {
        Random random = new Random();
        var result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = random.Next(100);
            }
        }
        return result;
    }
}