// Crie um dicionário que contenha nomes de carros com uma lista de vezes que esse carro foi vendido nos ultimos 5 anos,em seguida calcule sua média.

namespace VendasCarros
{
    public class Exercicio11
    {
        public static void VendasCarros()
        {
            Dictionary<string, List<int>> carrosVendidos = new Dictionary<string, List<int>>();

            carrosVendidos["Porsche 911"] = new List <int>{12,18,5,22,9};
            carrosVendidos["Audi R8"] = new List<int>{17,25,10,8,20};
            carrosVendidos["Bugatti Veyron"] = new List<int>{13,8,19,10,11};

            foreach (var carro in carrosVendidos)
            {
                double mediavendas = carro.Value.Average();
                Console.WriteLine($"A média de vendas do {carro.Key} foi de {mediavendas}");
            }
        }
    }
}