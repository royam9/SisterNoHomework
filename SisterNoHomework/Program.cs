namespace SisterNoHomework;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("請輸入頭數量");

        if (!int.TryParse(Console.ReadLine(), out int head))
        {
            Console.WriteLine("請輸入正確參數");
            ReStart();
        };    
        
        Console.WriteLine("請輸入腳數量");

        if (!int.TryParse(Console.ReadLine(), out int feet))
        {
            Console.WriteLine("請輸入正確參數");
            ReStart();
        };

        if (head < 0 || feet < 0)
        {
            Console.WriteLine("請輸入正數");
            ReStart();
        }

        if (feet % 2 != 0)
        {
            Console.WriteLine("請不要把有殘缺腳的動物關在籠子裡");
            ReStart();
        }

        // 2x + 4y = feet
        // x + 2y = feet / 2
        // x + y = head
        // feet / 2  - head = y 

        int rabbitCount = feet / 2 - head;

        if (rabbitCount < 0)
        {
            Console.WriteLine("頭太多了齁");
            ReStart();
        }

        int chickenCount = head - rabbitCount;

        if (chickenCount < 0)
        {
            Console.WriteLine("輸入參數錯誤了啦");
            ReStart();
        }

        Console.WriteLine($"兔子數量：{rabbitCount}，雞數量：{chickenCount}");
        ReStart();
    }

    private static void ReStart()
    {
        AppDomain.CurrentDomain.ExecuteAssembly(
        System.Reflection.Assembly.GetExecutingAssembly().Location
        );
    }
}
