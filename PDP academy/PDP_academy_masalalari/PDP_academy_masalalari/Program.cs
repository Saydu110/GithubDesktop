using static System.Console;

class Programm
{
    static void Main(string[] args)
    {
        //5-masala
        /*for (int i = 100; i < 1000; i++)
        {
            int yuzlik = i / 100;
            int onlik = i / 10 % 10;
            int birlik = i % 10;

            if (yuzlik!=onlik && birlik!= onlik && yuzlik!=birlik)
            {
                WriteLine(i);
            }
        }*/
        //6-masala
        /*for (int i = 100; i < 500; i++)
        {
            int yuzlik = i / 100;
            int onlik = i / 10 % 10;
            int birlik = i % 10;

            if (yuzlik+onlik+birlik==15)
            {
                WriteLine(i);
            }
        }*/
        //7-masala
        /*for (int i = 1000; i < 10000; i++)
        {
            if (i%47==43 && i%43==40)
            {
                Console.WriteLine(i);
            }
        }*/
        //8-masala
        /*int jamiMasofa = 100; 

                int hozirgiKun = 1; 
                double masofa = 10; 

                while (masofa <= jamiMasofa)
                {
                    Console.WriteLine($"Kun {hozirgiKun}: {masofa} km");

                   
                    masofa *= 1.1;

                    
                    hozirgiKun++;
                }

                Console.WriteLine($"Barcha kungi bosgan yo'li summasi {jamiMasofa} km dan oshadi {hozirgiKun - 1} kun ichida.");
        */
        //9-masala
        /*for (int i = 30; i < 100; i++)
        {
            int birlik = i % 10;
            if (i%3==0 && (birlik == 2 || birlik == 4 || birlik == 8))
            {
                Console.WriteLine(i);
            }
        }*/
        //10-masala
        /*int N = 27;
        int M = 4;
        while (N >= M)
        {
            N -= M;
        }
        WriteLine(N);*/
        //11-masala
        /*double Bmasofa = 10;
        double jamiMasofa = 10;
        int kun = 1;
        while (Bmasofa<=20)
        {
            
            Bmasofa *= 1.1;
            if (jamiMasofa>=100)
            {
                WriteLine(jamiMasofa);
            }
            else
            {
                jamiMasofa += Bmasofa;
            }
            kun++;
        }
        WriteLine(kun);*/
        
        // Lesson 7
        //1-masala
        /*double son = 2;
        int darajasi = 3;
        double natija = SonningDarajasi(son, darajasi);
        WriteLine(natija);*/
        //2-masala
        /*int a = 23;
        Ishora(a);*/
        //3-masala
        /*int yil = 234;
        AsrYil(yil);*/
        //4-masala
        /*int son = 234567;
        int xonaSoni = Xonalik(son);
        WriteLine($"{son}-soni {xonaSoni} xonalik");*/
        //5-masala
        /*int num1 = 7;
        int num2 = 10;
        MinAndMax(num1,num2);*/
        //string name = "Salom Alisher\vwewe ";
        //WriteLine(name);
        //Lesson 8
        //1-masala
        /*Write("Matn kiriting : ");
        string matn = ReadLine()!;
        WriteLine(IsLower(matn));*/
        

    }

    static double SonningDarajasi(double son,int daraja)
    {
        double natija = 1;
        for (int i = 1; i <= daraja; i++)
        {
            natija = natija * son;
        }

        return natija;
    }
    static void Ishora(double son)
    {
        if (son < 0)
        {
            WriteLine("bu son manfiy : '-' ");
        }
        else if (son == 0)
        {
            WriteLine("bu son 0 ga teng ");
        }
        else
        {
            WriteLine("bu son musbat : '+' ");
        }
        
    }
    static void AsrYil(int yil)
    {
        if (yil<100)
        {
            WriteLine("1-asr");
        }else if (yil>=100)
        {
            int asr = yil / 100 + 1;
            WriteLine($"{asr}-asr");
        }else if (yil ==0)
        {
            WriteLine("0- yil bo'lishi mumkin emas ");
        }
        else
        {
            WriteLine("Miloddan avvalgi yillar");
        }
        
    }
    static int Xonalik(int son)
    {
        int count = 0;
        while (son>0)
        {
            son /= 10;
            count++;

        }

        return count;
    }
    static void MinAndMax(int x, int y)
    {
        if (x>y)
        {
            WriteLine(x + " " + y);
        }
        else
        {
            int temp = x;
            x = y;
            y = temp;
            WriteLine(x + " " + y);
        }
    }
    static string IsLower(string matn)
    {
        string kichikMatn = "";
        for (int i = 0; i < matn.Length; i++)
        {
            char harf = matn[i];
            if (harf >= 'A' && harf <= 'Z')
            {
                kichikMatn += (char)(harf + 32); 
            }
            else
            {
                kichikMatn += harf;
            }
        }
        return kichikMatn;
    }
    
}



