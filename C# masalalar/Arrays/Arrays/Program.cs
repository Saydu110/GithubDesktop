class Programm
{
    static void Main(string[] args)
    {
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
        Console.WriteLine("Fibonachi length :");
        int n = int.Parse(Console.ReadLine()!);

        int[] k = new int[n];
        int f = 1;
        int p = 1;
        for (int i = 0; i < n; i++)
        {
            k[i] = p;
            p += k[i-1];
            
        }

        foreach (var x  in k)
        {
            Console.WriteLine(x);
        }
        
        

    }
}