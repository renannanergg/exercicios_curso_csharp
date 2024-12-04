// Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

namespace OperaçõesBásicas
{
    public class Exercicio4
    {
        public static void QuatroOperações()
        {
            float a = 5;
            float b = 8;

            float soma = a + b;
            float subtração = a - b;
            float divisão = a / b;
            float multiplicação = a * b;

            Console.WriteLine("**************************************");
            Console.WriteLine($"Os números escolhidos foram {a} e {b}");
            Console.WriteLine("**************************************");
            Console.WriteLine($"A soma de {a} + {b} = {soma}");
            Console.WriteLine($"A subtração de {a} - {b} = {subtração}");
            Console.WriteLine($"A divisão de {a} / {b} = {divisão}");
            Console.WriteLine($"A multiplicação {a} x {b} = {multiplicação}");

        }
    }
}