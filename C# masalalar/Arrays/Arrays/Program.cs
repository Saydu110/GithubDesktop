using static System.Console;
class Programm
{
    static void Main(string[] args)
    {
        Random r = new Random();
        /*int[] k = { 1, 6, 7, 0, -9, 90 };
        for (int i = 0; i < k.Length; i++)
        {
            if (k[i]==0)
            {
                Console.WriteLine(k[i]=100);
            }
            else
            {
                Console.WriteLine(k[i]);
            }
        }*/

        /*double[] balans = { 1000, 2000, 3000, 4000 };
        string[] password = { "1111", "2222", "3333", "4444" };

        Console.WriteLine("parol kiriting : ");
        string parol = Console.ReadLine()!;
        bool check = false;
        int index = -1;
        for (int i = 0; i < password.Length; i++)
        {
            if (parol == password[i])
            {
                check = true;
                index = i;
                break;
                
            }
        }

        if (check)
        {
            Console.WriteLine(balans[index]);
        }*/

        /*int n;
        Console.WriteLine("array length : ");
        n = int.Parse(Console.ReadLine()!);

        int count = 0;
        int[] k = new int[n];
        Random r = new Random();

        for (int i = 0; i < n; i++)
        {
            k[i] = r.Next(-10, 10);
        }

        int[] yangiMusbat = new int[] {};
        int[] yangiManfiy = new int[] {};
        Console.WriteLine("Print Array");
        foreach (var x in k)
        {
            //Console.Write($"{x}, ");
            if (x>=0)
            {
                yangiMusbat= new[] { x };
            }
            else
            {
                yangiManfiy = new[] { x };
            }
        }*/

        /*foreach (var q in yangiMusbat)
        {
            Console.WriteLine($"{q}, ");
            Console.WriteLine();
        }

        foreach (var w in yangiManfiy)
        {
            Console.WriteLine($"{w}, ");
        }*/
        
        //1-masala
        /*int[] k = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        for (int i = 0; i < k.Length; i++)
        {
            Console.WriteLine(k.Length);
        }*/
        //2-masala
        /*Console.WriteLine("Array length : ");
        int n = int.Parse(Console.ReadLine()!);

        int[] k = new int[n];
        int daraja = 1;
        for (int i = 0; i < n; i++)
        {
            k[i] = daraja;
            daraja *= 2;
        }

        foreach (var x in k)
        {
            Console.WriteLine(x);
        }*/
        //3-masala
        /*Console.WriteLine("arif prog length :");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("a1 :");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("d :");
        int d = int.Parse(Console.ReadLine()!);
        int[] k = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            k[i] = a;
            a += d;
        }

        foreach (var x in k)
        {
            Console.WriteLine(x);
        }*/
        //4-masala
        /*Console.WriteLine("arif prog length :");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("b1 :");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("q :");
        int q = int.Parse(Console.ReadLine()!);
        int[] k = new int[n];

        for (int i = 0; i < n; i++)
        {
            k[i] = b;
            b *= q;
        }

        foreach (var x in k)
        {
            Console.WriteLine(x);
        }*/
        //5-masala
        /*Console.WriteLine("Fibonachi length :");
        int n = int.Parse(Console.ReadLine()!);

        int[] k = new int[n];
        int f = 1;
        int p = 1;
        k[0] = 0;
        k[1] = 1;
        k[2] = 1;
        for (int i = 3; i < n; i++)
        {
            k[i] = k[i-1]+k[i-2];
        }
        
        foreach (var x  in k)
        {
            Console.WriteLine(x);
        }*/
        //6-masala
        /*Write("array length : ");
        int n = int.Parse(ReadLine()!);
        Write("k[0] : ");
        int A = int.Parse(ReadLine()!);
        Write("k[1] : ");
        int B = int.Parse(ReadLine()!);
        
        int[] k = new int[n];
        for (int i = 2; i < k.Length; i++)
        {
            k[i] += k[i - 1];
        }*/
        //7-masala
        /*int[] k = { 21, 34, 5, 8, 9, 007, 234 };

        for (int i = k.Length-1; i >= 0; i--)
        {
            WriteLine(k[i]);
        }*/
        //8-masala
        /*Random r = new Random();
        Write("array length : ");
        int n = int.Parse(ReadLine()!);

        int[] k = new int[n];
        for (int i = 0; i < n; i++)
        {
            k[i] = r.Next(0, 10);
        }

        int count = 0;
        foreach (var x in k)
        {
            if (x%2!=0)
            {
                WriteLine(x);
                count++;
            }
            
        }
        Write($"toq sonlar soni {count}");*/
        //9-masala
        /*Write("Array length : ");
        int n = int.Parse(ReadLine()!);

        int[] k = new int[n];
        for (int i = 0; i <k.Length; i++)
        {
            k[i] = r.Next(1, 100);
        }

        foreach (var l in k)
        {
            Write($"{l}, ");
        }
        
        WriteLine("---------");
        for(int x = k.Length -1; x>=0 ; x--)
        {
            if(k[x]%2==0)
            {
                WriteLine(k[x]);
            }
        }*/
        //10-masala
        /*Write("array length : ");
        int n = int.Parse(ReadLine()!);

        int[] k = new int[n];
        for (int i = 0; i < k.Length; i++)
        {
            k[i] = r.Next(10, 100);
        }

        foreach (var l in k)
        {
            Write($"{l}, ");
        }
        WriteLine();
        foreach (var x in k)
        {
            if (x % 2 == 0)
            {
                Write($"{x}, ");
            }
        }
        WriteLine();
        for (int i = k.Length-1; i >=0; i--)
        {
            if (k[i]%2!=0)
            {
                Write($"{k[i]},");
            }
        }*/
        //11-masala
        /*Write("array length : ");
        int n = int.Parse(ReadLine()!);
        Write("Karrali son : ");
        int A = int.Parse(ReadLine()!);
        
        int[] k = new int[n];
        for (int i = 0; i < k.Length; i++)
        {
            k[i] = r.Next(1, 100);
        }

        foreach (var x in k)
        {
            Write($"{x}, ");
        }
        WriteLine("---");
        for (int i = A; i < k.Length; i+=A)
        {
            Write($"{k[i]}, ");
        }*/
        //12-masala
        /*Write("array length : ");
        int n = int.Parse(ReadLine()!);

        int[] k = new int[n];

        for (int i = 0; i < k.Length; i++)
        {
            k[i] = r.Next(0, 100);
        }

        foreach (var x in k)
        {
            Write($"{x}, ");
        }
        WriteLine();
        for (int i = 0; i < k.Length; i += 2)
        {
            WriteLine($"k[{i}] => {k[i]}");
        }*/
        //13-masala
        /*Write("array length : ");
        int n = int.Parse(ReadLine()!);

        int[] k = new int[n];

        for (int i = 0; i < k.Length; i++)
        {
            k[i] = r.Next(0, 100);
        }

        foreach (var x in k)
        {
            Write($"{x}, ");
        }
        WriteLine();
        for (int i = k.Length-1; i >=1; i-=2)
        {
            WriteLine($"k[{i}] => {k[i]}");
        }*/
        //14-masala
        
        
        

    }
}