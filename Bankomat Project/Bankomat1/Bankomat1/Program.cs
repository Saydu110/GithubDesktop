using static System.Console;
class Programm
{
    public static double balans = 999999;
    public static string password = "1111";
    static void Main(string[] args)
    {       WriteLine("Xush kelibsiz!!!");
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
            string a = ReadLine()!;
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
        WriteLine("1-Balans ko'rish\n2-Naqd Pul olish\n3-Sms xabarnoma\n4-To'lovlar\n5-Parol o'zgartirish");
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
            case 4:
            { 
                WriteLine("\n1-Kamunal to'lovlar\n2-Soliq\n3-Internet\n4-Mobile\n5-Jarimalar");
                Write("Menudan birini tanlang : "); 
                tanlov1= int.Parse(ReadLine()!);
                switch (tanlov1)
                {
                    //kamunal 
                    case 1:
                    {
                        WriteLine("\n1-Suv\n2-Gaz\n3-Svet\n4-Chiqindi");
                        Write("Menudan birini tanlang : ");
                        tanlov1 = int.Parse(ReadLine()!);
                        switch (tanlov1)
                        {
                            //Suv
                            case 1:
                            {
                                
                            }break;
                            //Gaz
                            case 2:
                            {
                                
                            }break;
                            //Swet
                            case 3:
                            {
                                
                            }break;
                            //chiqindi
                            case 4:
                            {
                                
                            }break;
                        }

                    }break;
                    //Soliq
                    case 2:
                    {
                        
                    }break;
                    //Internet
                    case 3:
                    {
                        
                    }break;
                    //Mobile
                    case 4:
                    {
                        
                    }break;
                    //Jarimalar
                    case 5:
                    {
                        
                    }break;
                }
            }break;
            case 5:
            {
                WriteLine("Yangi parolni kiriting : ");
                string newPassword = ReadLine()!;
                password = newPassword;
                WriteLine("paroliningiz muvafaqiyatli o'zgartirildi");
            }break;
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