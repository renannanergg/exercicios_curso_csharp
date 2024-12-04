// Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.


namespace NotasAlunos
{
    public class Exercicio7
    {
        public static void NotasAlunos()
        {
            Dictionary<string, List<double>> alunosAvaliados = new Dictionary<string, List<double>>();

            alunosAvaliados["Renan"] = new List<double>{8.5,10,8.75};
            alunosAvaliados["Ana"] = new List<double>{6.5,10,9.5};
            alunosAvaliados["Maria"] = new List<double>{8.5,5,7};

            foreach(var aluno in alunosAvaliados)
            {
                double soma = 0;
                for (int i = 0; i < aluno.Value.Count; i++){
                    soma += aluno.Value[i];
                }
                double media = soma / aluno.Value.Count;
                Console.WriteLine($"A média de {aluno.Key}: {media}");
            }
        }
    }
}
