using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {

            Console.Clear();

            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Soma ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Multiplicação ");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Porcentagem");
            Console.WriteLine("6 - Sair da calculadora");

            Console.WriteLine("-----------");
            Console.WriteLine("Selecione uma opção");

            short res = short.Parse(Console.ReadLine());

            /* if (res == 1)
                 Soma();

             if (res == 2)
                 Subtracao();

             if (res == 3)
                 Multiplicacao();

             if (res == 4)
                 Divisao();

             if ((res >= 5))
                 Console.WriteLine("Por favor escolha entre as 4 opções.");*/
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Porcentagem(); break;
                case 6: System.Environment.Exit(0); break;
                default: Console.WriteLine("Digite um numero entre 1 e 4"); Menu(); break;

            }
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");

            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");

            float n2 = float.Parse(Console.ReadLine());

            float nt = n1 + n2;
            Console.WriteLine($"O resultado da soma é: {nt}");

            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");

            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");

            float n2 = float.Parse(Console.ReadLine());

            float nt = n1 - n2;

            Console.WriteLine($"O resultado da subtração é: {nt}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor");

            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor ");

            float n2 = float.Parse(Console.ReadLine());

            float nt = n1 * n2;

            Console.WriteLine($"O resultado da multiplicação é: {nt}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor");

            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor ");

            float n2 = float.Parse(Console.ReadLine());

            float nt = n1 / n2;

            Console.WriteLine($"O resultado da divisão é: {nt}");

            Console.ReadKey();
            Menu();
        }
        static void Porcentagem()
        {

            Console.Clear();
            Console.WriteLine("Digite um numero");

            double n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            double n2 = float.Parse(Console.ReadLine());

            double nPorcentagem = (n1 / 100) * n2;
            Console.WriteLine($"Quanto é {n1}% de {n2}? ");
            Console.WriteLine(nPorcentagem);
            Console.ReadKey();
            Menu();
            /*  Console.WriteLine("Digite a porcentagem que deseja calcular: ");
              double n1 = double.Parse(Console.ReadLine());

              Console.WriteLine("Digite o valor a ser calculado:");
              double n2 = double.Parse(Console.ReadLine());

              double nPorcentagem = (n1 / 100) * n2;
              Console.WriteLine($"O resultado do calculo de porcentagem é: {nPorcentagem}");

              Console.ReadKey();
              Menu();*/


        }
    }
}