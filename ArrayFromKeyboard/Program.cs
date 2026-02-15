namespace ArrayFromKeyboard;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Введите любое целое число: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Массив, который получился в итоге.");
        foreach (var i in arr)
        {
            Console.WriteLine($"Элемент массива: {i}\t");
        }
    }
}