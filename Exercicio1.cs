// Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".

namespace Média
{
    public class Exercicio1
    {
        public static void MédiaAluno()
        {
            Console.Write("Digite sua nota: ");
            string nota = Console.ReadLine()!;
            int notaMedia = int.Parse(nota);

            if (notaMedia < 5)
            {
                Console.WriteLine($"Sua nota foi {notaMedia}, você foi REPROVADO");
            }
            else if (notaMedia >= 5)
            {
                Console.WriteLine($"Sua nota foi {notaMedia}, você foi APROVADO");
            }
        }
    }
}