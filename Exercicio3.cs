// Criar um jogo que gere um numero aleatório e o usuário deva advinhar qual é esse número.

namespace JogoAdivinhação
{
    public class Exercicio3
    {
        public static void AdvinharNumero()
        {
           do {
                Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1,101);

            Console.Write("Advinhe o numero entre 1 a 100: ");
            string palpite = Console.ReadLine()!;
            int numeroPalpite = int.Parse(palpite);

            if (numeroPalpite == numeroSecreto)
            {
                Console.WriteLine("Parabéns, você acertou !");
            break;
            }
            else if (numeroPalpite != numeroSecreto)
            {
                Console.WriteLine("Você errou !");
            }
           } while(true);

        Console.WriteLine("Jogo encerrado.");
        }
    }
}
