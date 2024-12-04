// Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.

namespace Quiz
{
    public class Exercicio9
    {
        public static void Quiz()
        {
            Dictionary<string, string> PerguntasRespostas = new Dictionary<string, string>();
            PerguntasRespostas["Qual capital do Brasil ? "] = "Brasilia";
            PerguntasRespostas["Quem é o presidente dos USA? "] = "Trump";
            PerguntasRespostas["Quem é o melhor jogador do mundo? "] = "Messi";

            int pontuação = 0;

            foreach (var pergunta in PerguntasRespostas)
            {
                Console.WriteLine(pergunta.Key);
                Console.Write("Sua reposta: ");
                string respostaUsuario = Console.ReadLine()!;

                if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
                {
                    Console.WriteLine("Correto !\n");
                    pontuação ++;
                }
                else
                {
                    Console.WriteLine($"Incorreto ! A resposta correta é: {pergunta.Value}\n");
                }
            }

            Console.WriteLine("Quiz Encerrado !");
            Console.WriteLine($"Você acertou {pontuação} de {PerguntasRespostas.Count}");
            
        }
    }
}