// Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

namespace SistemaLogin
{
    public class Exercicio10
    {
        public static void SistemaLogin()
        {
            Dictionary<string, string> CadastroUsuarios = new Dictionary<string, string>();

            Console.Write("Crie um nome de usuário: ");
            string usuario = Console.ReadLine()!;
            Console.Write("Crie uma senha: ");
            string senha = Console.ReadLine()!;

            CadastroUsuarios.Add(usuario,senha);
            Console.WriteLine("Usuário cadastrado com sucesso !");
            Console.Clear();

            foreach (var cadastro in CadastroUsuarios)
            {
                Console.WriteLine($"******Cadastro do Usuário******");
                Console.WriteLine($"User: {cadastro.Key}");
                Console.WriteLine($"Senha: {cadastro.Value}");
            }
            
        }
    }
}