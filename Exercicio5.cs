// Criar uma lista de bandas vazia e adicione suas bandas prediletas, em seguida Utilize a estrutura 'for' para mostrar todas as suas bandas preferidas.

namespace ListaDeBandas
{
    public class Exercicio5
    {
        public static void ListarBandas()
        {
            List<string> bandas = new List<string> {};
            string banda;

            do{
                Console.Write("Adicione uma banda ou digite 'sair' para parar: ");
                banda = Console.ReadLine()!;
                if (banda == "sair")
                {
                    Console.Clear();
                break;
                }
                bandas.Add(banda);
                Console.WriteLine("Banda adicionada com sucesso !");
                Console.Clear();

            }while(banda != "sair");

            Console.WriteLine("------ Lista de Bandas ------");
            for (int i = 0; i < bandas.Count; i ++)
            {
                Console.WriteLine($"-{bandas[i]}");
            }
        }
    }
}