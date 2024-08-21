namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos" !! CHECK !! 1/6
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Os veiculos estacionados são: ");
            for(int cont = 0; cont < veiculos.Count ; cont++)
                {
                    Console.WriteLine("Veiculo N*:  Placa:   ");
                    Console.WriteLine($"     {cont+1}         {veiculos[cont]}");
                }

            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa  !! CHECK !! 2/6
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,   !! CHECK !! 3/6
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal  !! CHECK !!  4/6
                // *IMPLEMENTE AQUI*
                decimal horas = 0;
                horas = Convert.ToDecimal(Console.ReadLine());
                decimal valorTotal = 0; 
                valorTotal = precoInicial + (precoPorHora * horas);
                

                // TODO: Remover a placa digitada da lista de veículos   !! CHECK !!  5/6
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados  !! CHECK !! 6/6
                for(int cont = 0; cont < veiculos.Count ; cont++)
                {
                    Console.WriteLine("Veiculo N*:  Placa:   ");
                    Console.WriteLine($"     {cont+1}         {veiculos[cont]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
