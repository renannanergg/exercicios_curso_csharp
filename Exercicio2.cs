//Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.

namespace ListaDeLinguagens
{
    public class Exercicio2
    {
        public static void Lista()
        {
            List<string> linguagem = new List<string> {"C#", "JavaScript", "Java"};
            
            Console.Write("Digite uma opção de 1 até 3 para ver as linguagens da lista: ");
            string linguaguemEscolhida =Console.ReadLine()!;
            int opção = int.Parse(linguaguemEscolhida);

            switch (opção)
            {
                case 1:
                    Console.WriteLine($"A opção {opção} é a linguagem: {linguagem[0]}");
                    break;
                case 2:
                    Console.WriteLine($"A opção {opção} é a linguagem: {linguagem[1]}");
                    break;
                case 3:
                    Console.WriteLine($"A opção {opção} é a linguagem: {linguagem[2]}");
                    break;
                default:
                    Console.WriteLine("Opção inválida !");
                    break;
        
            }

        }
    } 

}
