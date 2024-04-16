using System.Xml;
using static System.Console;

class Programm
{
    static void Main(string[] args)
    {
        while (true)
        {

            //    Lesson3

            // 1-masala
            /*int number, yuzlik, onlik, birlik;
            Write("Biron son kiriting : ");
            number = int.Parse(ReadLine()!);
            yuzlik = number / 100;
            onlik = number / 10 % 10;
            birlik = number % 10;
            Write($"yuzlik : {yuzlik}\nonlik : {onlik}\nbirlik : {birlik}");*/
            // 2-masala
            /*int number, yuzlik, onlik, birlik;
            Write("Biron son kiriting : ");
            number = int.Parse(ReadLine()!);
            yuzlik = number / 100;
            onlik = number / 10 % 10;
            birlik = number % 10;
            int sum = yuzlik + onlik + birlik;
            Write($"Raqamlari yig'indisi : {sum} ga teng");*/
            // 3-masala 
            /*int number, yuzlik, onlik, birlik;
            Write("Biron son kiriting : ");
            number = int.Parse(ReadLine()!);
            yuzlik = number / 100;
            onlik = number / 10 % 10;
            birlik = number % 10;
            int kopaytma = yuzlik * onlik * birlik;
            Write($"Raqamlari ko'paytmasi : {kopaytma}");*/
            // 4-masala
            /*int number, yuzlik, onlik, birlik;
            Write("Biron son kiriting : ");
            number = int.Parse(ReadLine()!);
            yuzlik = number / 100;
            onlik = number / 10 % 10;
            birlik = number % 10;
            int ortaArifmetik = (yuzlik + onlik + birlik) / 3;
            Write($"Raqamlari O'rta Arifmetigi : {ortaArifmetik} ga teng ");*/
            // 5-masala 
            /*int number, yuzlik, onlik, birlik;
            Write("Biron son kiriting : ");
            number = int.Parse(ReadLine()!);
            yuzlik = number / 100;
            onlik = number / 10 % 10;
            birlik = number % 10;
            int controry = birlik * 100 + onlik * 10 + yuzlik;
            Write(controry);*/
            // 6-masala 
            /*int number, yuzlik, onlik, birlik;
            Write("Biron son kiriting : ");
            number = int.Parse(ReadLine()!);
            yuzlik = number / 100;
            onlik = number / 10 % 10;
            birlik = number % 10;
            int mix = birlik * 100 + yuzlik * 10 + onlik;
            Write(mix);*/
            // 7-masala
            /*int number, yuzlik, onlik, birlik;
            Write("Biron son kiriting : ");
            number = int.Parse(ReadLine()!);
            yuzlik = number / 100;
            onlik = number / 10 % 10;
            birlik = number % 10;
            int mix = onlik * 100 + yuzlik* 10 + birlik;
            Write(mix);*/
            // 11-masala 
            /*int belgi;
            Write("belgilar sonini kiriting :  ");
            belgi = int.Parse(ReadLine()!);
            int b = (belgi / 45) * 60;
            Write(b);*/
            // 12-masala
            /*int sekund;
            Write("belgilar sonini kiriting :  ");
            sekund = int.Parse(ReadLine()!);
            int minut = sekund / 60;
            Write(minut);*/
            // 13-masala
            /*int sekund;
            Write("belgilar sonini kiriting :  ");
            sekund = int.Parse(ReadLine()!);
            int minut = sekund / 60;
            int soat = minut / 60;
            Write(soat);*/
            // 14-masala
            /*Write("secund : ");
            int secund = int.Parse(ReadLine()!);
            int min = secund / 60;
            int soat = min / 60;
            int min1 = min % 60;
            int secund1 = secund % 60;
            Write($"{soat} hour {min1} minutes {secund1} secund");*/
            // 15-masala
            /*Write("secund : ");
            int secund = int.Parse(ReadLine()!);
            int min = secund / 60;
            int soat = min / 60;
            int min1 = min % 60;
            int secund1 = secund % 3600;
            Write($"{soat} hour  {secund1} secund");*/

            //Lesson 4

            // 1-masala
            /*int a, b;
            Write($"A : ");
            a = int.Parse(ReadLine()!);
            Write($"B : ");
            b = int.Parse(ReadLine()!);
            int yigindi = a + b;
            Write($"ikki sonning yig'indisi : {yigindi} ga teng");*/
            // 2-masala
            /*int a, b;
            Write($"A : ");
            a = int.Parse(ReadLine()!);
            Write($"B : ");
            b = int.Parse(ReadLine()!);
            int kopaytma = a * b;
            Write($"ikki sonning ko'paytmasi : {kopaytma} ga teng");*/
            // 3-masala
            /*int a;
            Write("Enter your number : ");
            a = int.Parse(ReadLine()!);
            int b = a % 7;
            Write($"sonni 7 ga bo'lingandagi qoldig'i {b} ga teng");*/
            // 4-masala
            /*int son;
            Write("Ikki xonali son kiriting : ");
            son = int.Parse(ReadLine()!);
            int birlik = son % 10;
            int onlik = son / 10;
            Write($"Bu son ga teskari son {birlik*10 + onlik} ga teng");*/
            // 5-masala
            /*int a, b;
            Write("A kesmaning uzunligini kiriting : ");
            a = int.Parse(ReadLine()!);
            Write("B kesmaning uzunligini kiriting : ");
            b = int.Parse(ReadLine()!);
            int kesma = a / b;
            Write($"A kesmadan {kesma} ta B kesmaning uzunligidagi kesmalarni olish mumkin");*/
            // 6-masala
            /*string name;
            Write($"Ismingizni kiriting : ");
            name = ReadLine()!;
            Write($"Salom {name}");*/
            // 7-masala
            /*string name;
            Write($"Ismingizni kiriting : ");
            name = ReadLine()!;
            Write($"Salom a{name}a");*/
            // 8-masala
            /*string obj;
            Write($"Ihtiyoriy so'z kiriting : ");
            obj = ReadLine()!;
            Write($"{obj}siz");*/
            // 9-masala
            /*int a, b, c, d;
            Write("Bino : ");
            a = int.Parse(ReadLine()!);
            Write("Qavat : ");
            b = int.Parse(ReadLine()!);
            Write("Xona : ");
            c = int.Parse(ReadLine()!);
            Write("Parta : ");
            d = int.Parse(ReadLine()!);
            int all = a * b * c * d;
            Write($"All table is : {all}");*/
            // 10-masala 
            /*int a;
            Write("ixtiyoriy son kiriting : ");
            a = int.Parse(ReadLine()!);
            double b = Math.Pow(a, 2);
            Write($"Bu sonning kvadrati {b} ga teng");*/
            // 11-masala
            /*double a, S, P;
            Write("Kvadratning tomonini kiriting : ");
            a = int.Parse(ReadLine()!);
            S = Math.Pow(a, 2);
            P = 4 * a;
            WriteLine($"Kvadratning yuzi {S} ga teng");
            WriteLine($"Kvadratning perimetri {P} ga teng");*/
            // 12-masala
            /*double r, d, l, s;
            Write("Aylananing radiusini kiriting : ");
            r = int.Parse(ReadLine()!);
            d = 2 * r;
            l = 2 * Math.PI * r;
            s = Math.PI * Math.Pow(r, 2);
            WriteLine($"yuza : {s}");
            WriteLine($"uzunligi : {l}");
            Write($"diametri : {d}");*/
            // 13-masala
            /*double gradus;
            Write("Gradusni kiriting : ");
            gradus = double.Parse(ReadLine()!);
            double rd = gradus * (Math.PI / 180);
            Write($"radian : {rd}");*/
            // 14-masala
            /*double m, s, k, mm;
            Write("metr : ");
            m = double.Parse(ReadLine()!);
            s = m * 100;
            mm = m * 1000;
            k = m / 1000;
            WriteLine($"millimetr : {mm}");
            WriteLine($"santimetr : {s}");
            Write($"kilometr : {k}");*/
            // 15-masala
            /*int a, yuzlik, onlik, birlik;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            yuzlik = a / 100;
            onlik = a / 10 % 10;
            birlik = a % 10;
            int sum = (yuzlik - 1) * 100 + (onlik - 1) * 10 + (birlik - 1);
            Write(sum);*/
            // 16-masala
            /*int a, b;
            WriteLine("a: ");
            a = int.Parse(ReadLine()!);
            WriteLine("b: ");
            b = int.Parse(ReadLine()!);
            a = a + b;
            b = a - b;
            WriteLine(b);
            a = a - b;
            Write(a);*/
            // 17-masala
            /*int a, b, c;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            Write("b : ");
            b = int.Parse(ReadLine()!);
            Write("c : ");
            c = int.Parse(ReadLine()!);
            a = a + b + c;
            b = a - (b + c);
            c = a - (b + c);
            a = a - (b + c);
            WriteLine($"a : {a}");
            WriteLine($"b : {b}");
            Write($"c : {c}");*/
            // 18-masala
            /*double x, y, x2, y2, x3, y3;
            Write("A nuqtaning x kordinatasini kiriting : ");
            x = int.Parse(ReadLine()!);
            Write("A nuqtaning y kordinatasini kiriting : ");
            y = int.Parse(ReadLine()!);
            Write("B nuqtaning x kordinatasini kiriting : ");
            x2 = int.Parse(ReadLine()!);
            Write("B nuqtaning y kordinatasini kiriting : ");
            y2 = int.Parse(ReadLine()!);
            Write("C nuqtaning x kordinatasini kiriting : ");
            x3 = int.Parse(ReadLine()!);
            Write("C nuqtaning y kordinatasini kiriting : ");
            y3 = int.Parse(ReadLine()!);
            double AB = Math.Sqrt(Math.Pow((x2 - x), 2) + Math.Pow((y2 - y), 2));
            double BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double AC = Math.Sqrt(Math.Pow((x3 - x), 2) + Math.Pow((y3 - y), 2));

            WriteLine($"AB = {AB}");
            WriteLine($"BC = {BC}");
            Write($"AC = {AC}");*/

            //Lesson 5

            // 1-masala
            /*int a;
            Write("Ixtiyoriy son kiriting : ");
            a = int.Parse(ReadLine()!);
            if (a>9&&a<100)
            {
                Write("Bu son ikki xonali");
            }
            else
            {
                Write("Bu ikki xonali son emas");
            }*/
            // 2-masala
            // 3-masala
            /*int a;
            Write("Ixtiyoriy son kiriting : ");
            a = int.Parse(ReadLine()!);
            if (a%2!=0)
            {
                Write("Kiritilgan son Toq son");
            }
            else
            {
                Write("Kiritilgan son Toq son emas\n BU son juft");
            }*/
            // 4-masala
            /*int a;
            Write("Ixtiyoriy son kiriting : ");
            a = int.Parse(ReadLine()!);
            if (a<=20)
            {
                Write("oraliqda");
            }
            else
            {
                Write("oraliqda emas");
            }*/
            // 5-masala
            /*int a;
            Write("ixtiyori son kiriting : ");
            a = int.Parse(ReadLine()!);
            int onlik = a % 100 / 10;
            if (onlik%2==0)
            {
                Write("onliklar honasidagi raqam juft");
            }
            else
            {
                Write("onliklar honasidagi raqam juft emas");
            }*/
            // 6-masala
            /*int a;
            Write("ixtiyori son kiriting : ");
            a = int.Parse(ReadLine()!);
            if (a%15==0 || a%14==0)
            {
                Write("Bu son 3va5 yoki 2va7 ga karrali");
            }
            else
            {
                Write("Bu son 3va5 yoki 2va7 ga karrali emas");
            }*/
            // 7-masala
            /*Write("Ixtiyoriy son kiriting : ");
            int a = int.Parse(ReadLine()!);
            if (a>99 &&a<1000)
            {
                Write("Bu son 3 xonali");
            }
            else
            {
                Write("Bu son 3 xonali emas");
            }*/
            // 8-masala
            /*Write("Ixtiyoriy son kiriting : ");
            int a = int.Parse(ReadLine()!);
            if (a > 9999 && a < 100000 && a % 3 == 0)
            {
                Write("Berilgan son 5 xonali va 3ga karrali");
            }
            else
            {
                Write("Berilgan son 5 xonali va 3ga karrali emas");
            }*/
            // 9-masala 
            /*Write("ixtiyori son kiriting : ");
            int a = int.Parse(ReadLine()!);
            int onlik = a % 100 / 10;
            if (a>999 && a<10000 && onlik%2==0)
            {
                Write("Berilgan son 4 xonali o’nlar xonasi juft ");
            }
            else
            {
                Write("Berilgan son 4 xonali o’nlar xonasi juft emas");
            }*/
            // 10-masala
            /*Write("Ixtiyoriy son kiriting : ");
            int a = int.Parse(ReadLine()!);
            int yuzlik = a % 1000 / 100;
            int onlik = a % 100 / 10;
            if (a>999 && a<10000 && yuzlik%3==0 || onlik%2!=0)
            {
                Write("Berilgan son 4 xonali yuzlar xonasi 3ga karrali yoki o’nlar xonasi toq son");
            }
            else
            {
                Write("Berilgan son 4 xonali yuzlar xonasi 3ga karrali yoki o’nlar xonasi toq son emas");
            }*/
            // 11-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            int yuzlik = a % 1000 / 100;
            if (yuzlik%2!=0 && yuzlik%3==0)
            {
                Write("Berilgan son yuzlar xonasidagi sonning toq uchga karrali");
            }
            else
            {
                Write("Berilgan son yuzlar xonasidagi sonning toq uchga karrali emas");
            }*/
            // 12-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            if (a%3!=0 && a%5!=0 && a%2!=0)
            {
                bool b = true;
                Write(b);
            }
            else
            {
                bool b = false;
                Write(b);
            }*/
            // 13-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            Write("b : ");
            int b = int.Parse(ReadLine()!);
            if (a%b==0)
            {
                Write("true");
            }
            else
            {
                Write("false");
            }*/
            // 14-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            Write("b : ");
            int b = int.Parse(ReadLine()!);
            Write("c : ");
            int c = int.Parse(ReadLine()!);
            if ((a==b && a==c && b==c) || a!=b && a!=c && b!=c)
            {
                WriteLine("true");
            }
            else
            {
                WriteLine("false");
            }*/
            // 15-masala
            /*int a;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            if (a%10!=0 && (a%2==0 || a%5==0))
            {
                Write("true");
            }
            else
            {
                Write("false");
            }*/
            // 16-masala
            /*int a;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            int yuzlik = a / 100;
            int birlik = a % 10;
            if (a >99 && a<1000 && yuzlik==birlik)
            {
                WriteLine("true");
            }
            else
            {
                WriteLine("false");
            }*/
            // 17-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            Write("b : ");
            int b = int.Parse(ReadLine()!);
            Write("c : ");
            int c = int.Parse(ReadLine()!);
            if ((a>=0&&b<0&&c<0) || (b>=0&&a<0&&c<0) || (c>=0&&b<0&&a<0))
            {
                WriteLine("true");
            }
            else
            {
                WriteLine("false");
            }*/
            // 18-masala
            /*Write("a : ");
            double a = double.Parse(ReadLine()!);
            Write("b : ");
            double b = double.Parse(ReadLine()!);
            Write("c : "); 
            double c = double.Parse(ReadLine()!);
            double C = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double B = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)); 
            double A= Math.Sqrt(Math.Pow(c, 2) + Math.Pow(b, 2));
            if (c==C || a==A || b==B)
            {
                WriteLine("true");
            }
            else
            {
                WriteLine("false");
            }*/
            
            // Lesson 6
            
            // 1-masala
            /*int a;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            int yigindi = 0;
            int kopaytma = 1;
            if (a%2==0)
            {
                for (int i = a; i !=0 ; i/=10)
                {
                    int oxirgiRaqam = i % 10;
                    yigindi += oxirgiRaqam;
                }      
                WriteLine($"Bu son juft uning raqamlari yig'indisi : {yigindi} ga teng");
            }
            else
            {
                for (int i = a; i !=0 ; i/=10)
                {
                    int oxirgiRaqam = i % 10;
                    kopaytma *= oxirgiRaqam;
                }
                WriteLine($"Bu son toq uning raqamlari ko'paytmasi : {kopaytma}ga teng");
            }*/
            // 2-masala
            /*int a;
            Write("Ixtiyoriy son kiriting : ");
            a = int.Parse(ReadLine()!);
            WriteLine(Modul(a));*/
            // 3-masala
            /*int a;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            int onlik = a % 100 / 10;
            int yuzlik = a / 100;
            int birlik = a % 10;
            if (yuzlik<onlik)
            {
                yuzlik = onlik;
            }

            if (yuzlik<birlik)
            {
                yuzlik = birlik;
            }
            WriteLine($"Katta raqam : {yuzlik}");*/
            // 4-masala
            /*int a;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            int onlik = a % 100 / 10;
            int yuzlik = a / 100;
            int birlik = a % 10;
            if (yuzlik>onlik)
            {
                yuzlik = onlik;
            }

            if (yuzlik>birlik)
            {
                yuzlik = birlik;
            }
            WriteLine($"Kichik raqam : {yuzlik}");*/
            // 5-masala
            /*int a;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            double onlik = a % 100 / 10;
            double yuzlik = a / 100;
            double birlik = a % 10;
            double katta = 0;
            double kichik = 0;
            if (yuzlik<onlik)
            {
                katta = onlik;
                kichik = yuzlik;
            }
            if (yuzlik<birlik)
            {
                katta = birlik;
                kichik = yuzlik;
            }
            
            WriteLine($"Katta raqamning kichik raqamga nisbati : {katta/kichik}");*/
            // 6-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            if (a<0)
            {
                WriteLine("Bu son manfiy");
            }
            else if (a > 0)
            {
                WriteLine("Bu son musbat"); 
            }
            else
            {
                WriteLine("Bu son nolga teng");
            }*/
            // 7-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            int son = 0;
            for (int i = a; i >=1; i/=10)
            {
                son++;
            }
            WriteLine($"berilgan son {son} xonali");
            while (a>=1)
            {
                a /= 10;zo
                son++;
            }
            WriteLine($"berilgan son {son} xonali");*/
            // 8-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            int onlik = a % 100 / 10;
            if (onlik%3==0)
            {
                WriteLine($"bu sonning ikkilangani : {2*a}");
            }
            else if (onlik%4==0)
            {
                WriteLine($"bu son 4 ga karrali : {a-a%10}");   
            }*/
            // 9-masala
            /*int a;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            if (a%2==0)
            {
                Write("Bu son 2 ga karrali");
            }
            if (a%3==0)
            {
                Write("Bu son 3 ga karrali");
            }
            if (a%4==0)
            {
                Write("Bu son 4 ga karrali");
            }
            if (a%5==0)
            {
                Write("Bu son 5 ga karrali");
            }
            if (a%6==0)
            {
                Write("Bu son 6 ga karrali");
            }
            if (a%7==0)
            {
                Write("Bu son 7 ga karrali");
            }
            if (a%9==0)
            {
                Write("Bu son 9 ga karrali");
            }
            else
            {
                Write("zo''''r");
            }*/
            // 10-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            Write("b : ");
            int b = int.Parse(ReadLine()!);
            if (a<0 || b<0)
            {
                WriteLine(a*b);
            }

            if (a>0 && b>0)
            {
                WriteLine(Math.Pow(a,2)+ Math.Pow(b,2));
            }
            else
            {
                WriteLine((a+b)/2);
            }*/
            // 11-masala
            /*Write("Oy raqamini kiriting : ");
            int a = int.Parse(ReadLine()!);
            if (a>0 && a<=2 || a == 12)
            {
                WriteLine("Qish");
            }

            if (a>=3 && a<6)
            {
                WriteLine("Bahor");
            }

            if (a>=6 && a<9)
            {
                WriteLine("Yoz");
            }

            if (a>=9 && a<12)
            {
                WriteLine("Kuz");
            }*/
            // 12-masala
            /*Write("a : ");
            int a = int.Parse(ReadLine()!);
            Write("b : ");
            int b = int.Parse(ReadLine()!);
            Write("c : ");
            int c = int.Parse(ReadLine()!);
            if (a>=0&&b>=0&&c>=0)
            {
                WriteLine("Barcha sonlar musbat!!!");
            }

            if (expr)
            {
                
            }*/
            // 13-masala
            /*int son;
            Write("3 xonali son kiriting : ");
            son = int.Parse(ReadLine()!);
            int yuzlik = son / 100;
            int onlik = son / 10 % 10;
            int birlik = son % 10;

            string s = "";

            switch (yuzlik)
            {
                case 1: s = "bir yuz"; break;
                case 2: s = "ikki yuz"; break;
                case 3: s = "uch yuz"; break;
                case 4: s = "to'rt yuz"; break;
                case 5: s = "besh yuz"; break;
                case 6: s = "olti yuz"; break;
                case 7: s = "yetti yuz"; break;
                case 8: s = "sakkiz yuz"; break;
                case 9: s = "to'qqiz yuz"; break;
                
            }

            switch (onlik)
            {
                case 1: s += " o'n"; break;
                case 2: s += " yigirma"; break;
                case 3: s += " o'ttiz"; break;
                case 4: s += " qirq"; break;
                case 5: s += " ellik"; break;
                case 6: s += " oltmish"; break;
                case 7: s += " yetmish"; break;
                case 8: s += " sakson"; break;
                case 9: s += " to'qson"; break;
            }

            switch (birlik)
            {
                case 1: s += " bir"; break;
                case 2: s += " ikki"; break;
                case 3: s += " uch"; break;
                case 4: s += " to'rt"; break;
                case 5: s += " besh"; break;
                case 6: s += " olti"; break;
                case 7: s += " yetti"; break;
                case 8: s += " sakkiz"; break;
                case 9: s += " to'qqiz"; break;
            }
            WriteLine(s);*/
            // 14-masala
            int son;
            Write("3 xonali son kiriting : ");
            son = int.Parse(ReadLine()!);
            int i = 0;
            for (; son>=1; i++)
            {
                son /= 10;
                
            }

            switch (i)
            {
                case 1: 
            }




            // Shaxmat Saydu110/C-masalalar
            /*while (true)
            {
                char harf;
                int raqam;
                Write("Joylashgan harf : ");
                harf = char.Parse(ReadLine()!);
                Write("Joylashgan raqam : ");
                raqam = int.Parse(ReadLine()!);

                Write("Yurish harf : ");
                char harfY = char.Parse(ReadLine()!);
                Write("Yurish raqami : ");
                int raqamY = int.Parse(ReadLine()!);

                bool check = ((harf != harf && harf <= 'H' && raqam == raqamY) ||
                              (raqam != raqam && raqam <= 8 && harf == harfY));
                WriteLine(check);
            }*/
            // kordinata
            /*int x, y;
            Write("x : ");
            x = int.Parse(ReadLine()!);
            Write("y : ");
            y = int.Parse(ReadLine()!);

            bool check = ((x <= 0 && y > 0) || (x > 0 && y >= 0));
            Write(check);*/
            //
            /*int a, b;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            Write("b : ");
            b = int.Parse(ReadLine()!);

            bool check = (a % b == 0);
            Write(check);*/
            //
            /*int a, b, c;
            Write("a : ");
            a = int.Parse(ReadLine()!);
            Write("b : ");
            b = int.Parse(ReadLine()!);
            Write("c : ");
            c = int.Parse(ReadLine()!);

            bool check = ((a % 7 == 0) || (b % 7 == 0) || (c % 7 == 0));
            Write(check);*/
            //
            /*string a;
            Write("True/False : ");
            a = ReadLine()!;
            bool check = (!(a == "true"));
            Write(check);

            bool b;
            Write("True/False : ");
            b = bool.Parse(ReadLine()!);
            bool check1 = (!b);
            Write(check1);*/
            //
            /*bool b;
            Write("True/False : ");
            b = bool.Parse(ReadLine()!);
            int a = Convert.ToInt32(b);
            Write(a);*/
            //
            /*short s = 290;
            byte b = (byte)s;
            Write(b);*/

            // int k = 0b1001;
            // Write(k);
            //
            /*int a, b, c;
Write("a : ");
a = int.Parse(ReadLine()!);
Write("b : ");
b = int.Parse(ReadLine()!);
Write("c : ");
c = int.Parse(ReadLine()!);
a = a + b + c;
b = a - (b + c);
c = a - (b + c);
a = a - (b + c);
WriteLine($"a : {a}");
WriteLine($"b : {b}");
Write($"c : {c}");*/

            /*int x, y;
            Write("x : ");
            x = int.Parse(ReadLine()!);
            Write("y : ");
            y = int.Parse(ReadLine()!);
            if ((x>0 && y>0)||(x<0 && y<0))
            {
                Write("Bu nuqta I yoki II chorakda yotadi.");
            }
            else
            {
                Write("Bu nuqta I yoki II chorakda yotadi.");
            }*/


        }
    }

    static double Modul(int a)
    {
        if (a<0)
        {
            return -a;
        }

        return a;
    }

    public static void Numbers(int son)
    {
        for (int i = 0; son>=1; son/=10)
        {
            i = son % 10;
            Console.WriteLine(i);
        }
    }

   
}
