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
    
            /*Write("n : ");
            int n = int.Parse(ReadLine()!);
            int k = 0;
            int kvadrat=0;
            while (kvadrat<=n)
            {
                k++;
                kvadrat = k * k;
            }
            WriteLine(k);*/
            
            /*Write("k : ");
            int k = int.Parse(ReadLine()!);
            Write("n : ");
            int n = int.Parse(ReadLine()!);
            int s = 1;
            while (s<=n)
            {
                WriteLine(k);
                s++;
            }*/
            
            /*Write("f : ");
            int f = int.Parse(ReadLine()!);
            int i = 1;
            int y = f;
            while (i<=y)
            {
                WriteLine($"{i}={f}");
                i++;
                f--;
            }*/
            
            //5-masala
            /*Write("son kiriting : ");
            int s = int.Parse(ReadLine()!);

            int n = 1;
            int count = -1;
            while (n<=s)
            {
                n *= 2;
                count++;
            }
            WriteLine(count);*/
            //6-masala
            /*Write("son kiriting : ");
            int s = int.Parse(ReadLine()!);
            int y = 1;
            while (s>0)
            {
                y *= s;
                s -= 2;
                
            }
            WriteLine(y);*/
            //7-masala
            /*Write("son kiriting : ");
            int s = int.Parse(ReadLine()!);
            int kvadrat = 1;
            int k = 1;
            while (kvadrat<=s)
            {
                k++;
                kvadrat = k * k;
            }
            WriteLine(k);*/
            //8-masala
            /*Write("son kiriting : ");
            int s = int.Parse(ReadLine()!);
            int kvadrat = 1;
            int k = 1;
            while (kvadrat<=s)
            {
                k++;
                kvadrat = k * k;
            }
            WriteLine(k-1);*/
            //9-masala
            /*Write("son kiriting : ");
            int s = int.Parse(ReadLine()!);
            int k = 1;
            int count = 0;
            while (k<=s)
            {
                k *= 3;
                count++;
            }
            WriteLine(count);*/
            //10-masala
            
    }
}