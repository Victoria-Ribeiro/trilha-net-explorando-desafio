namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            bool capacidade = false;

            capacidade = hospedes.Count <= Suite.Capacidade ? true : false;
            if (capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*

                Console.WriteLine("Capacidade de Suite excedida");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            try
            {
                int quantidadeHospides = Hospedes.Count;
                return quantidadeHospides;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Não há hospedes");
                return 0;
            }     
            
            
           
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            int quantHospedes = ObterQuantidadeHospedes();

            if (quantHospedes > 0)
            {
                if (DiasReservados >= 10)
                {
                    valor = DiasReservados * Suite.ValorDiaria;
                    valor -= valor * 0.10M;
                }
                else
                    valor = DiasReservados * Suite.ValorDiaria;

                return valor;
            }
            else { return valor; }
        }
    }
}