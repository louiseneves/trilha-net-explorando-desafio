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
            

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                
                throw new Exception("A quantidade de hóspedes é maior que a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            int quantidade = 0;
            quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados >= 10)
            {
                decimal desconto = (valor / 100) * 10;
                valor = valor - desconto;
            }
            else
            {
                // Caso não, o valor permanece o mesmo
                valor = valor;
            }

            return valor;
        }
    }
}