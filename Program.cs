internal class Program
{
    private static void Main(string[] args)
    {
        int choice = 0;
        do
        {
        int a = 0, b = 0;
        Console.WriteLine("1. In hinh hop");
        Console.WriteLine("2. In hinh tam giac goc vuong tren trai");
        Console.WriteLine("3. In hinh tam giac goc vuong tren phai");
        Console.WriteLine("4. In hinh tam giac goc vuong duoi trai");
        Console.WriteLine("5. In hinh tam giac goc vuong duoi phai");
        Console.WriteLine("6. In hinh tam giac can");
        Console.WriteLine("0. Thoat chuong trinh");

        string input = Console.ReadLine();
        choice = Convert.ToInt32(input);
        switch (choice)
        {
            case 0: Console.WriteLine("Hen gap lai"); break;
            case 1: 
                for (int i = 1; i <= a; i++)
                {
                    for(int j = 1; j <= b; j++)
                    {
                        Console.Write(" * ");
                    }
                    Console.WriteLine();
                }; break;
            case 2: 
                for (int i = a; i > 0; i--)
                {
                   for(int j = i; j > 0; j--)
                   {
                       Console.Write(" * ");
                   }
                   Console.WriteLine();
                }; break;
            case 3: 
                for (int i = a; i >= 1; i--)
                {
                   for(int j = i; j <= a; j++)
                   {
                       if (j <= (a-i))
                       {
                        Console.Write("   ");
                       } else
                       {
                        Console.Write(" * ");
                       }
                   }
                   Console.WriteLine();
                }; break;
            case 4: 
                for (int i = 1; i <= a; i++)
                {
                   for (int j = 1; j <= i; j++)
                   {
                       Console.Write(" * ");
                   }
                   Console.WriteLine();
                }; break;
            case 5: 
                for (int i = 1; i <= a; i++)
                {
                    for(int j = 1; j <= a; j++)
                    {                               
                        if (j <= a - i)
                        {
                            Console.Write("   ");
                        } else
                        {
                            Console.Write(" * ");
                        }
                    }
                    Console.WriteLine();
                }; break;
            case 6: 
                for (int i = 1; i <= a; i++)
                {
                   for(int j = 1; j < 2*a; j++)
                   {
                       if (Math.Abs(a-j) < i)
                       {
                        Console.Write(" * ");
                       } else
                       {
                        Console.Write("   ");
                       }
                   }
                   Console.WriteLine();
                }; break;
            default: Console.WriteLine("Khong co lua chon do"); break;
        }
        } while (choice != 0);
    }
}