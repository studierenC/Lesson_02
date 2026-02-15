namespace ReverseArray;

class Program
{
    static void Main()
    {
        int evenSum = 0;
        int[] arr = { 1, 2, 3, 4, 5 };
        int minValue = arr.Length - 1;
        
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Element {i}: {arr[i]}");
            if (arr[i] % 2 == 0)
            {
                evenSum += arr[i];
            }

            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
        }
        Console.WriteLine($"Сумма четных элементов в массиве равна: {evenSum}");
        Console.WriteLine($"Наименьший элемент в массиве равен: {minValue}");
    }
}