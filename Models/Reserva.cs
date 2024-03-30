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
            if (hospedes.Count <= Suite.Capacidade)
                Hospedes = hospedes;
            else
                throw new ArgumentException("A quantidade de hóspedes deve ser menor ou igual a capacidade da Suíte!");
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        { return Hospedes.Count; }

        public decimal CalcularValorDiaria()
        {
            decimal desconto = (DiasReservados >= 10) ? 0.9M : 1M;
            decimal valor    = DiasReservados * Suite.ValorDiaria * desconto;

            return valor;
        }
    }
}