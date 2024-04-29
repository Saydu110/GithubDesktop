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

            Write("n : ");
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
            WriteLine(yigindi);


    }
}