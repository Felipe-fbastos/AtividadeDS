using System;
using System.Globalization;


namespace Exercicio01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para executar DetalharData\nDigite 2 para executar CalcularINSS ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    DetalharData();
                    break;
                case 2:
                    CalcularINSS();
                    break;
                default:
                    Console.WriteLine("Digito inválido");
                    break;
            }
            
        }

        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data:");
            DateTime dtHora = DateTime.Parse(Console.ReadLine());

            if (dtHora.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("{0:dddd}, Dia {0:dd} de {0:MMMM} de {0:yyyy} e são {0:hh:mm}", dtHora);
            }
            else
            {
                Console.WriteLine("{0:dddd}, Dia {0:dd} de {0:MMMM} de {0:yyyy}", dtHora);
            }
        }



        public static void CalcularINSS()
        {
            Console.WriteLine("Digite seu salário:");
            double salario = double.Parse(Console.ReadLine());

            double descInss;
            string formatado;


            if (salario <= 1212)
            {
                //Calcula a porcentagem de desconto
                descInss = salario * 0.075;
                formatado = descInss.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu desconto é de {formatado}");
                //Faz o desconto do Inss no salario e exibe
                salario -= descInss;
                formatado = salario.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu salário com desconto {formatado}\n");
            }
            else if (salario > 1212.01 && salario <= 2427.35)
            {
                descInss = salario * 0.09;
                formatado = descInss.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu desconto é de {formatado}");

                salario -= descInss;
                formatado = salario.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu sálario com desconto {formatado}\n");
            }
            else if (salario > 2427.35 && salario <= 3641.03)
            {
                descInss = salario * 0.12;
                formatado = descInss.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu desconto é de {formatado}");

                salario -= descInss;
                formatado = salario.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu sálario com desconto {formatado}\n");
            }
            else if (salario > 3641.04 && salario <= 7087.22)
            {
                descInss = salario * 0.14;
                formatado = descInss.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu desconto é de `{formatado}");

                salario -= descInss;
                formatado = salario.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu sálario com desconto {formatado}\n");
            }
            else if (salario > 7087.23)
            {
                descInss = salario * 0.14;
                formatado = descInss.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu desconto é de `{formatado}");

                salario -= descInss;
                formatado = salario.ToString("C2", CultureInfo.CurrentCulture);
                Console.WriteLine($"\nSeu sálario com desconto {formatado}");
            }


        
        }
    }
}