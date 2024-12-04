//Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.

namespace GerirEstoque
{
    public class Exercicio8
    {
        public static void GerirEstoque()
        {
            Dictionary <string, int> Estoque = new Dictionary <string, int>()!;
            Estoque["Smartphones"] = 10;
            Estoque["Notebooks"] = 12;
            Estoque["Tablets"] = 5;
            Estoque["Air Pods"] = 18;
            Estoque["Smart Watch"] = 15;

            foreach(var produto in Estoque)
            {
                Console.WriteLine($"Quantidade de {produto.Key} em estoque: {produto.Value}");
            }
        }
    }
}