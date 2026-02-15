namespace ArrayFromKeyboard;

class Program
{
    static void Main()
    {
        Console.Write("Укажите длинну массива:\t");
        int arrLength = int.Parse(Console.ReadLine() ?? "0"); 
        int[] arr = new int[arrLength];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Введите любое целое число для элемента массива с индексом {i}: ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        
        Console.WriteLine("\nМассив, который получился в итоге.");
        
        foreach (var i in arr)
        {
            Console.WriteLine($"\tЭлемент массива: {i}");
        }
    }
}