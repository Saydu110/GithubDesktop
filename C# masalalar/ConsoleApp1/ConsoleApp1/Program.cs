using static System.Console;

class Programm
{
    
    static void Main(string[] args)
    {
        /*Write("start : ");
        int s = int.Parse(ReadLine()!);
        Write("finish : ");
        int f = int.Parse(ReadLine()!);
        while (s<=f)
        {
            WriteLine(s);
            s++;
        }*/
        
        /*Write("start : ");
        int s = int.Parse(ReadLine()!);
        Write("finish : ");
        int f = int.Parse(ReadLine()!);
        while (f<=s)
        {
            WriteLine(s);
            f--;
        }*/
        
        /*Write("start : ");
        int s = int.Parse(ReadLine()!);
        Write("finish : ");
        int f = int.Parse(ReadLine()!);
        if (s > f)
        {
            while (f<= s)
            {
                WriteLine(s);
                s--;
            }
        }
        else
        {
            while (s<=f)
            {
                WriteLine(s);
                s++;
            }
        }*/

        
        
            
            /*int s = 1;
            int count = 0;
            int yigindi = 0;
            while (s!=0)
            {
                Write("start : "); 
                s = int.Parse(ReadLine()!);
                yigindi+= s;
                count++;
            }
            WriteLine($"siz {count} ta son kiritdingiz!\nyig'indisi {yigindi} ga teng");*/
            
            Random r = new Random();

            /*Write("n : ");
            int n = int.Parse(ReadLine()!);
            int s = 1;
            int yigindi = 0;
            while (s<=n)
            {
                int x = r.Next(1, 10);
                WriteLine(x);
                yigindi += x;
                s++;
            }
            WriteLine(yigindi);*/
            // while 
            // 1-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            Write("b : ");
            int b = int.Parse(ReadLine()!);
            while (a>=b)
            {
                a -= b;
            }
            WriteLine(a);*/
            // 2-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            Write("b : ");
            int b = int.Parse(ReadLine()!);
            int count = 0;
            while (a>=b)
            {
                a -= b;
                count++;
            }
            WriteLine(count);*/
            // 3-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            Write("b : ");
            int b = int.Parse(ReadLine()!);
            int count = 0;
            while (a>=b)
            {
                a -= b;
                count++;
            }
            WriteLine($"{count} butun {a} qoldiqe");*/
            // 4-masala
            /*Write("n : ");
            int n = int.Parse(ReadLine()!);
            int x = 1;
            int count = -1;
            bool check = false;
            while (x<=n)
            {
                
                if (x == n)
                {
                    check = true;
                }
                
                x *= 3;
                count++;
            }

            if (check)
            {
                WriteLine($"Kiritilgan son 3 ning {count} darajasi");
            }
            else
            {
                WriteLine("Kiritilgan son 3 ning darajasi emas");
            }*/
    
            Write("n : ");
            int n = int.Parse(ReadLine()!);
            int k = 0;
            int kvadrat=1;
            while (kvadrat<=n)
            {
              
                kvadrat = k*k; // 2*2=4 4ning kvadrati 4*4=16 ga teng
                k++;
            }
            WriteLine(k);

    }
}