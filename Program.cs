using System;

namespace Calculadora_usando_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perguntar a operação - Entrada;
            Console.WriteLine("Qual operação deseja realizar? /nSoma, Subtracao, Multiplicação, Divisão");
            string operacao = Console.ReadLine().ToLower();

            // Pedir o 1º número - Entrada;
            Console.WriteLine("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            // Pedir o 2º número - Entrada;
            Console.WriteLine("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            // Executar o cálculo - Processamento;

            float resultado = 0;

            switch(operacao) {

                case "soma":
                    resultado = num1 + num2;
                    break;

                case "subtracao":
                    resultado = num1 - num2;
                    break;

                case "multiplicacao":
                    resultado = num1 * num2;
                    break;

                case "divisao":
                    resultado = num1 / num2;
                    break;
               
                default:
                    Console.WriteLine("Operação inválida! :(");
                    break;
            }


            // Mostrar o resultado - Saída

            Console.WriteLine($"Cálculo de {operacao} de {num1} com {num2} = {resultado}");
        }

    }
}
