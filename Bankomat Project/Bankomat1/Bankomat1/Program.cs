using static System.Console;
class Programm
{
    public static double balans = 999999;
    static void Main(string[] args)
    {
        WriteLine("Xush kelibsiz!!!");
        Language();
    }
    private static void Language()
    {
        WriteLine("Tilni tanlang");
        WriteLine("1-Uzbek\n2-English\n3-Russia");
        int tanlov = int.Parse(ReadLine()!);
        switch (tanlov)
        {
            case 1:
            {
                Parol();
            }break;
            case 2:
            {
                WriteLine("Qadrli mijoz sizdan uzr so'raymiz. Bizning til bilish darajamiz hali unchalik yaxshi emas!!!");
            }break;
            case 3:
            {
                WriteLine("Qadrli mijoz sizdan uzr so'raymiz. Bizning til bilish darajamiz hali unchalik yaxshi emas!!!");
            }
            break;
            
        }
    }
    public static void Parol()
    {
        int tekshirish = 1;
        while (tekshirish <= 3)
        {
            WriteLine("Parol kiriting : ");
            int a = int.Parse(ReadLine()!);
            int password = 1111;
            if (a == password)
            {
                Menu();
            }
            else
            {
                WriteLine("Parolni xato kiridingiz!!! Qayta urinib ko'ring");
            }

            tekshirish++;
        }
            WriteLine("!!!Urinishlar soni tugadi!!!");
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
                SmsXabarnoma();
                Menu();
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
    public static void SmsXabarnoma()
    {
        WriteLine("1-Nomer ulash\n2-Nomer Almashtirish\n3-Nomerni ko'rish");
        int nomer = 971652026;
        int tanlov = int.Parse(ReadLine()!);
        switch (tanlov)
        {
            case 1: 
            {
                Write("For.ex = 971650000\nNomerni kiriting : +");
                int number = int.Parse(ReadLine()!);
                WriteLine($"Sizning {number} raqamingiz kartangizga ulandi");
                WriteLine("_______________________________________________");
            } 
            break;
            case 2:
            {
                Write("For.ex = 971650000\nYangi raqamni kiriting : +");
                int newNumber = int.Parse(ReadLine()!);
                nomer = newNumber;
                WriteLine($"Sizning {nomer} raqamingiz kartangizga ulandi");
                WriteLine("_______________________________________________");
            }
            break;
            case 3:
            {
                WriteLine(nomer);
            }
            break;
        }
    }
}