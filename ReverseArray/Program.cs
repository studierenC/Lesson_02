namespace ReverseArray;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Element {i}: {arr[i]}");   
        }
    }
}