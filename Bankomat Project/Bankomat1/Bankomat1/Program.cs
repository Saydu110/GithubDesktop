using static System.Console;

class Programm
{
    static void Main(string[] args)
    {
        WriteLine("Xush kelibsiz!!!\nTilni tanlang");
        WriteLine("1-Uzbek\n2-English\n3-Russia");
        int tanlov = int.Parse(ReadLine()!);
        switch (tanlov)
        {
            case 1:
            {
                WriteLine("Parol kiriting : ");
                int a = int.Parse(ReadLine()!);
                Parol(a);
            }
                break;
        }
    }

    public static void Parol(int parol)
    {
        for (int i = 0; i <= 3; i++)
        { int password = 1111;

            if (parol == password)
            {
                Menu();
            }
            else
            {
                WriteLine("Parolni xato kiridingiz!!! Qayta urinib ko'ring");
            }
        }
    }

    static void Menu()
    {
        WriteLine("_______________________________________________");
        WriteLine("1-Balans ko'rish\n2-Naqd Pul olish\n3-Sms xabarnoma\n");
        int tanlov1 = int.Parse(ReadLine()!);
        switch (tanlov1)
        {
            case 1:
            {
                
            }
            break;
            case 2:
            {
                
            } 
            break;
            case 3:
            {
                
            } 
            break;
            case 4:
            {
                
            }
            break;
        }
        
    }
}