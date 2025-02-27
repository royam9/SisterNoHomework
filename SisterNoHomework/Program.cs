namespace SisterNoHomework;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("請輸入頭數量");
        int head = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("請輸入腳數量");
        int feet = Convert.ToInt32(Console.ReadLine());

        if (head < 0 || feet < 0)
        {
            Console.WriteLine("請輸入正數"); 
            return;
        }

        if (feet % 2 != 0)
        {
            Console.WriteLine("請不要把有殘缺腳的動物關在籠子裡");
            return;
        }

        // 2x + 4y = feet
        // x + 2y = feet / 2
        // x + y = head
        // feet / 2  - head = y 

        int rabbitCount = feet / 2  - head;

        if (rabbitCount < 0)
        {
            Console.WriteLine("頭太多了齁");
            return;
        }

        int chickenCount = head - rabbitCount;

        Console.WriteLine($"兔子數量{rabbitCount}，雞數量{chickenCount}");
    }
}
