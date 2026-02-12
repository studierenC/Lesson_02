namespace Step_02;

class Program
{
    static void Main(string[] args)
    {
        uint oddCounter = 0, evenCounter = 0;
        int oddSum = 0, evenSum = 0;
        
        Console.WriteLine("Добрый день, милостивый господин!");
        
        Console.WriteLine("Введите первое значение диапазона: ");
        int leftLimit = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите второе значение диапазона: ");
        int rightLimit = int.Parse(Console.ReadLine());

        while (leftLimit <= rightLimit)
        {
            if (leftLimit % 2 == 0)
            {
                evenCounter += 1;
                evenSum += leftLimit;
            }
            else
            {
                oddCounter += 1;
                oddSum += leftLimit;
            }
            
            leftLimit += 1;
        }
        
        Console.WriteLine("Господин, в указаном тобой диапазоне чисел я обнаружил четных чисел - {0} и нечетных чисел - {1}", evenCounter, oddCounter);
        Console.WriteLine("Сумма четных чисел равна {0}", evenSum);
        Console.WriteLine("Сумма нечетных чисел равна {0}", oddSum);
    }
}