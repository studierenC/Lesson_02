namespace Triangle;

class Program
{
    static void Main()
    {
        Console.WriteLine("Что нужно нарисовать (треугольник/квадрат)?");
        string msg = Console.ReadLine();

        if (msg == "треугольник")
        {
            Console.Write("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());
        
            Console.Write("Введите ширину треугольника: ");
            int width = int.Parse(Console.ReadLine());
            
            Triangle(height, width);
        }
        
        if (msg == "квадрат")
        {
            Console.Write("Введите ширину квадрата: ");
            int width = int.Parse(Console.ReadLine());
            
            Square(width);
        }
    }

    static void Square(int width)
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Triangle(int height, int width)
    {
        for (int row = 1; row <= height; row++)
        {
            for (int star = 1; star <= width; star++)
            {
                Console.Write("*");

                if (row == star)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}