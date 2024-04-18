using static System.Console;
class Programm
{
    public static double balans = 999999;
    static void Main(string[] args)
    {
        WriteLine("Xush kelibsiz!!!");
        metka:
        WriteLine("Tilni tanlang");
        WriteLine("1-Uzbek\n2-English\n3-Russia");
        int tanlov = int.Parse(ReadLine()!);
        switch (tanlov)
        {
            case 1:
            {
                WriteLine("Parol kiriting : ");
                int a = int.Parse(ReadLine()!);
                Parol(a);
                goto metka;

            }break;
        }
    }
    public static void Parol(int parol)
    {
        int password = 1111;

        if (parol == password)
        {
            Menu();
        }
        else
        {
            WriteLine("Parolni xato kiridingiz!!! Qayta urinib ko'ring");
        }
    }

    static void Menu()
    {
        WriteLine("_______________________________________________");
        WriteLine("1-Balans ko'rish\n2-Naqd Pul olish\n3-Sms xabarnoma");
        int tanlov1 = int.Parse(ReadLine()!);
        switch (tanlov1)
        {
            case 1:
            {
                Balans();
                Menu();
            }
                break;
            case 2:
            {
                WriteLine("Qancha summa yechib olmoqchisiz");
                double summa = double.Parse(ReadLine()!);
                NaqdPulOlish(summa);
                Menu();
            }
                break;
            case 3:
            {
                
            }
                break;
        }
    }
    public static double Balans()
    {
        WriteLine(balans);
        return balans;
    }
    public static double NaqdPulOlish(double summa)
    {
        balans -= summa;
        WriteLine($"Sizdan {summa} so'm yechib olindi");
        WriteLine("_______________________________________________");
        return balans;
    }
    
}