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
            /*Write("son kiriting : ");
            int s = int.Parse(ReadLine()!);
            int k = 1;
            int count = 0;
            while (k<=s)
            {
                k *= 3;
                count++;
            }

            WriteLine(count-1);*/
            //11-masala
            /*Write("son kiriting : ");
            int n = int.Parse(ReadLine()!);
            int k = 1;
            int yigindi = 1;
            while (yigindi<n)
            {    
                k++;
                yigindi += k;
            }
            WriteLine($"Yig'indi = {yigindi}");
            WriteLine($"k = {k}");*/
            //12-masala
            /*Write("son kiriting : ");
            int n = int.Parse(ReadLine()!);
            int k = 1;
            int yigindi = 1;
            while (yigindi<=n)
            {
                k++;
                yigindi += k;
            }
            WriteLine(yigindi-k);
            WriteLine(k-1);*/
            //13-masala
            /*Write("son kiriting : ");
            int a = int.Parse(ReadLine()!);
            double k = 2;
            double yigindi = 1;
            while (yigindi<=a)
            {
                yigindi = yigindi + 1/k;
                k++;
            }
            WriteLine(yigindi);
            WriteLine(k);*/
            //14-masala
            /*Write("son kiriting : ");
            int a = int.Parse(ReadLine()!);
            double k = 2;
            double yigindi = 1;
            while (yigindi<=a)
            {
                yigindi = yigindi + 1/k;
                k++;
            }
            WriteLine(yigindi-1/k);
            WriteLine(k-1);*/
            //15-masala
            /*Write("boshlang'ich summani kiriting : ");
            double bsum = double.Parse(ReadLine()!);
            int p = 20;
            double y = bsum;
            int count = 0;
            while (bsum<=2*y)
            {
                bsum += 0.20 * bsum;
                count++;
            }
            WriteLine($"{count} oyda sizning pulingiz 2 marta ko'payadi.");*/
            //16-masala
            /*Write("keyingi kunda necha foizga oshirmoqchisiz : ");
            double p = double.Parse(ReadLine()!);
            double s = 10;
            double f = 200;
            int count = 0;
            while (s<=f)
            {
                s += (p / 100) * s;
                count++;
            }
            WriteLine(s);
            WriteLine(count);*/
            //17-masala
            /*WriteLine("n : ");
            int n = int.Parse(ReadLine()!);
            WriteLine("m : ");
            int m = int.Parse(ReadLine()!);
            int count = 0;
            while (n>m)
            {
                n -= m;
                count++;
            }
            WriteLine($"{count} butun {n} qoldiq");*/
            //18-masala
            /*Write("son kiriting : ");
            int s = int.Parse(ReadLine()!);
            int q;
            while (s>0)
            {
                q = s % 10;
                Write(q);
                s /= 10;
            }*/
            //19-masala
            /*Write("son kiriting : ");
            string s = ReadLine()!;
            int q = 0;
            int yigindi = 0;
            while (q<s.Length)
            {
                WriteLine(s[q]);
                int raqam = int.Parse(s[q].ToString());
                yigindi += raqam;
                q++;
            }
            WriteLine($"{yigindi}");*/
            //20-masala
            /*Write("n : ");
            int n = int.Parse(ReadLine()!);
            bool check = false;
            while (n>0)
            {
                int q = n % 10;
                if (q==2)
                {
                    check = true;
                }
                n /= 10;
                
            }

            if (check)
            {
                WriteLine(true);
            }
            else
            {
                WriteLine(false);
            }*/
            //21-masala
            /*Write("n : ");
            int n = int.Parse(ReadLine()!);
            bool check = false;
            while (n>0)
            {
                int q = n % 10;
                if (q%2!=0)
                {
                    check = true;
                }
                n /= 10;
                
            }

            if (check)
            {
                WriteLine(true);
            }
            else
            {
                WriteLine(false);
            }*/
            //22-masala
            Write("n : ");
            int n = int.Parse(ReadLine()!);
            int q = 2;
            bool check = false;
            while (q<n)
            {
                if (n%q==0)
                {
                    check = true;
                }
                q++;
            }

            if (check)
            {
                WriteLine("Bu son tub emas");
            }
            else
            {
                WriteLine("Bu son tub ");
            }




    }
}