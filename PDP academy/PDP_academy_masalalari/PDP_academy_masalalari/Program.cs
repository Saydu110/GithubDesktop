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
        int N = 27;
        int M = 4;
        while (N >= M)
        {
            N -= M;
        }
        WriteLine(N);
    }    
}