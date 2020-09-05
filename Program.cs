using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DataTyperHela
{
    class Program
    {
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välj vilken uppgift du vill kolla på:\n" +
                "1. Vilket tal passar var?\n" +
                "2. floats och doubles\n" +
                "3. Skillnaden på två tal\n" +
                "4. Deklarera en integer till Hex 254\n" +
                "5. Använd en char för att skriva ut unicode 72\n" +
                "6. Är du kille eller tjej?\n" +
                "7. Sätt ihop två strings till en\n" +
                "8. Använd \"\" i en string\n" +
                "9. Rita ut en triangel med \xA9\n" +
                "10. Skriv in dina uppgifter\n" +
                "11. Byt plats på två tal");


            switch (Console.ReadLine())
            {
                case ("1"):
                    one();
                    return true;
                    break;
                case ("2"):
                    two();
                    return true;
                    break;
                case ("3"):
                    three();
                    return true;
                    break;
                case ("4"):
                    four();
                    return true;
                    break;
                case ("5"):
                    five();
                    return true;
                    break;
                case ("6"):
                    six();
                    return true;
                case ("7"):
                    seven();
                    return true;
                case ("8"):
                    eight();
                    return true;
                case ("9"):
                    nine();
                    return true;
                case ("10"):
                    ten();
                    return true;
                case ("11"):
                    eleven();
                    return true;
                //case ("12"):
                //    twelve();
                //    return true;
                //case ("13"):
                //    thirteen();
                //    return true;
                //case ("14"):
                //    fourteen();
                //    return true;
                default:
                    return true;
            }
        }
        private static void ReturnMainMenu()
        {

            Console.Write("Tryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static void one()
        {
            ushort Tal1 = 52130;
            sbyte Tal2 = -115;
            int Tal3 = 4825932;
            byte Tal4 = 97;
            short Tal5 = -10000;

            Console.WriteLine(Tal1);
            Console.WriteLine(Tal2);
            Console.WriteLine(Tal3);
            Console.WriteLine(Tal4);
            Console.WriteLine(Tal5);

            ReturnMainMenu();
        }
        private static void two()
        {
            Console.Clear();

            double Tal1 = 34.567839023;

            float Tal2 = 12.345f;
            double Tal3 = 8923.1234857;
            float Tal4 = 3456.091f;

            Console.WriteLine("This is a double {0}", Tal1);
            Console.WriteLine("This is a float {0}", Tal2);
            Console.WriteLine("This is a double {0}", Tal3);
            Console.WriteLine("This is a float {0}", Tal4);
            ReturnMainMenu();
        }
        private static void three()
        {
            Console.Clear();
            bool correct;

            Console.WriteLine("Skriv in första siffran:");
            float tal1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in andra siffran:");
            float tal2 = float.Parse(Console.ReadLine());
            //Här ser den hur mycket som skiljer sig mellan talen
            float answer = Math.Abs(tal1 - tal2);
            //If satsen skriver ut om den höll sig inom 0,000001 annars ger den ett felmeddelande
            if (answer <= 0.000001 && answer >= -0.000001)
            {
                correct = true;
                Console.WriteLine($"{correct}\n" +
                    $"Skillnaden på talen är: {answer}");
            }
            else
            {
                correct = false;
                Console.WriteLine($"{correct} \n" +
                    $"Skillnaden på talen är: {answer}");
                ReturnMainMenu();
            }
        }
        private static void four()
        {
            Console.Clear();
            //Integern omvandlar hextalet till heltal
            int hex = 0xFE;
            //Skriver ut i heltal
            Console.WriteLine($"{hex}");
            ReturnMainMenu();
        }
        private static void five()
        {
            Console.Clear();
            //Anväder char för att få ut unicode 72, jag har redan gjort om unicoden till hextal vilket blev 48
            char Unicode = '\x0048';
            Console.WriteLine(Unicode);
            ReturnMainMenu();
        }
        private static void six()
        {
            Console.Clear();
            bool isFemale = false;
            //Frågar om du är kille eller tjej
            Console.WriteLine("Är du tjej eller kille?");
            string svar = Console.ReadLine();
            //Omvandlar ditt svar till småbokstäver så det inte är case sensitive
            svar = svar.ToLower();
            //Ser om du svarat kille eller tjej och ger boolen ett true eller false
            switch (svar)
            {
                case ("kille"):
                    isFemale = false;
                    break;
                case ("tjej"):
                    isFemale = true;
                    break;
            }
            Console.Clear();
            //Skriver ut om du är tjej
            Console.WriteLine($"Är du en tjej?\n" +
                    $"{isFemale}");
            ReturnMainMenu();
        }
        private static void seven()
        {
            Console.Clear();
            string word1, word2, together;
            object temp;
            //Lägger ihop två strings till ett object och ett mellanslag mellan orden
            word1 = "Hello";
            word2 = "World!";
            temp = word1 + " " + word2;
            //Converterar objektet till en string
            together = Convert.ToString(temp);
            Console.WriteLine(together);
            ReturnMainMenu();
        }
        private static void eight()
        {
            Console.Clear();
            //Visar att man behöver använda \ innan "
            Console.WriteLine("The \"use\" of quotations causes difficulties.");
            Console.WriteLine("The use of quotations causes difficulties.");
            ReturnMainMenu();
        }
        private static void nine()
        {
            Console.Clear();
            //Designerar symbolen till en copyright symbol
            char c = '\xA9';
            //Otrolig onödig for loop/if sats, kan ta bort hela och det fungerar ändå
            for (int i = 0; i <= 4; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"   {c}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"  {c} {c}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($" {c}   {c}");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"{c} {c} {c} {c}");
                }
            }
            ReturnMainMenu();
        }
        private static void ten()
        {
            Console.Clear();

            string name, lastName, combinedName, gender;
            byte age;
            bool male = true;
            ulong uniqueNr, idNr;
            //Ber dig skriva in båda ditt namn och efternamn
            Console.WriteLine("skriv ditt namn och efternamn");
            combinedName = Console.ReadLine();
            //Indexerar var mellanslaget va mellan orden
                int index = combinedName.IndexOf(" ");
            //Lägger till ordet innan mellanslaget i första stringen
                name = combinedName.Substring(0, index);
            //Lägger till ordet som kom efter mellanslaget i den andra stringen
                lastName = combinedName.Substring(index + 1);               
            //frågar om din ålder och konverterar det till byte
            Console.WriteLine("Skriv in din ålder:");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("skriv om du är tjej eller kille:");
            gender = Console.ReadLine();
            //Ändrar ditt svar till små bokstäver så det inte är case sensitive
            gender = gender.ToLower();
            //Get boolen ett true eller false beroende på vad du svarade
            switch (gender)
            {
                case "tjej":
                    male = false;
                    break;
                default:
                    male = true;
                    break;
            }
            //Frågar om id/arbetsid och konverterar det till ulong
            Console.WriteLine("Skriv in ditt ID:");
            idNr = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ditt arbetsNr:");
            uniqueNr = ulong.Parse(Console.ReadLine());
            Console.Clear();
            //Skriver ut all info
            Console.WriteLine($"Namn: {name}\n" +
                $"Efternamn: {lastName}\n" +
                $"Ålder: {age}\n" +
                $"ID nummer: {idNr}\n" +
                $"Arbets nummer: {uniqueNr}");
            //Är osäker hur jag bäst får ut värdet ur boolen så gjorde en switch som skrev ut det
            switch (male)
            {
                case (true):
                    Console.WriteLine("Kön: Man");
                    break;
                default:
                    Console.WriteLine("Kön: Kvinna");
                    break;
            }
            ReturnMainMenu();
        }
        private static void eleven()
        {
            Console.Clear();
            int tal1, tal2, temp;
            Console.WriteLine("Skriv in första talet:");
                tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in det andra talet:");
                tal2 = int.Parse(Console.ReadLine());
            //Jag använder en temporär integer för att spara tal1 i tills jag kan ge tal2 det värdet
            temp = tal1;
            tal1 = tal2;
            tal2 = temp;
            Console.WriteLine($"ditt första tal är: {tal1}\n" +
                $"Andra talet är: {tal2}");
            ReturnMainMenu();
        }
    }

}
