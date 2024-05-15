using static System.Console;

class Programm
{
    static void Main(string[] args)
    {
        /*int x = 5;
        int y = 5;
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= y; j++)
            {
                if (i%2!=0)
                {
                    Write($" * ");
                }
                else
                {
                    Write($" {i} ");
                }
            }
            WriteLine();
        
        }*/
        
        /*for (char i = 'A'; i <= 'E' ; i++)
        {
            for (int j = 'A'; j <= 'E'; j++)
            {
                Console.Write($" {i} ");
            }

            WriteLine();
        }*/
        /*for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if (i==1 || i==5 || j==3)
                {
                    Write(" * ");
                }
                else
                {
                    Write("   ");
                }
            }
            WriteLine();
        }*/
        

        for (int i = 0; i < 100; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Clear();
        }
    }
}