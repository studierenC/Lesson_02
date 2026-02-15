namespace BuiltinMethods;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1,2,3,4,5,2,3,1,4,2,4};
        
        Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}");
        Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
        Console.WriteLine($"Сумма элементов в массиве: {arr.Sum()}");
        Console.WriteLine($"Сумма четных элементов в массиве: {arr.Where(i => i % 2 == 0).Sum()}");
        Console.WriteLine($"Минимальный нечетный элемент в массиве: {arr.Where(i => i % 2 != 0).Min()}");

        // Create array with unique elements
        int[] uniqueArr = arr.Distinct().ToArray();

        int[] orderedAscArr = arr.Distinct().OrderBy(i => i).ToArray();
        int[] orderedDescArr = arr.Distinct().OrderByDescending(i => i).ToArray();
    }
}