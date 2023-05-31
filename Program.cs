using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod:");
            Console.WriteLine("SingleOrDefault:");
            Console.WriteLine("Skip:");
            Console.WriteLine("SaveFile:");
            Console.WriteLine("Pyramid:");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    SingleOrDefault();
                    break;
                case 2:
                    Skip();
                    break;
                case 3:
                    SaveFile();
                    break;
                case 4:
                    Pyramid();
                    break;
                default:
                    Console.WriteLine("No match found");
                    break;
            }
            Console.ReadKey();
        }                
            public static void SingleOrDefault()
            {
                var result = new Dictionary<int, string>
            {
                {1, "SingleOr" },
                {2, "Default" },
            };

                result.ToList().ForEach(x =>
                    Console.WriteLine($"{x.Key} - {x.Value}"));
            }
            public static void Skip()
            {
                var domain = new Dictionary<string, string>()
                {
                };
                int y;
                y = 22;

                if (y == 20)
                {
                    Console.WriteLine("The value is 20 and condition is true");
                }
                else
                {
                    Console.WriteLine("The value is not 20 so conition is false");
                }
            }
            public static void SaveFile()
            {
            Console.WriteLine("Kui url on vale, siis annab" +
           "veateate. Kui on õige, siis ütleb, " +
           "et kõik on korras");
            Console.WriteLine("Kui on õige, siis loob faili " +
                "koos sinu sisestatud tekstiga");

            string wrongPath = "V:/Users/Ingvar/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/Ingvar/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }
            }
            public static void Pyramid()
            {
            int i, j, rows;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    //Console.Write("{0} ", t++);
                    Console.Write(i);
                }
                Console.Write("\n");
            
        
                }
            }
        }
    }

        

      


