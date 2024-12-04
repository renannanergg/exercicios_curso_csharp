// Crie uma lista de inteiros utilizando o List<int> e utilize o foreach para iterar sobre essa lista e exibir apenas os números pares.

namespace NumerosPares
{
    public class Exercicio6
    {
        public static void NumerosPares()
        {
            List<int> numeros = new List<int> {1,2,3,4,5,6,7,8,9,10};

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero}");
                }
            }
        }
    }
}