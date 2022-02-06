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
            Console.WriteLine("Olá, qual operação deseja fazer?");

            Console.WriteLine("Opção 1 - Soma");
            Console.WriteLine("Opção 2 - Subtração");
            Console.WriteLine("Opção 3 - Multiplicação");
            Console.WriteLine("Opção 4 - Divisão");
            Console.WriteLine("Sair - Tecle zero ");

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Selecione uma opção.");

            short respostaUsuario = short.Parse(Console.ReadLine());
            switch (respostaUsuario)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu();break;

            }
        }

        //Abaixo vemos os métodos das operações, no lugar de estar no Main, eles foram encapsulados e podem ser chamados a qualquer momento.
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultadoSoma = v1 + v2;

            Console.WriteLine($"O Resultado da soma é: {resultadoSoma}");

            Console.ReadKey();
               
        }

        static void Subtracao()
        {

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoSubtracao = v1 - v2;

            Console.WriteLine($"O Resultado da Subtração é: {resultadoSubtracao}");

            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoMultiplicacao = v1 * v2;

            Console.WriteLine($"O Resultado da Multiplicação é: {resultadoMultiplicacao}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoDivisao = v1 / v2;

            Console.WriteLine($"O Resultado da Divisão é: {resultadoDivisao}");
        }
    }
}
