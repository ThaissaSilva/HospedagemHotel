namespace HospedagemHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(){}

        public Reserva(int diasReservados){
            DiasReservados = diasReservados; 
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {           
            if(hospedes.Count <= Suite.Capacidade){
                Hospedes = hospedes;
            }else{
                throw new Exception("A capacidade da suíte é menor do que o número de hospedes recebido.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQtdHospedes()
        {
            int qtdHospedes = Hospedes.Count();
            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal desconto = 0.10M;
            decimal valorfinal = Suite.ValorDiaria * DiasReservados;

            if(DiasReservados >= 10){
                valorfinal -= Suite.ValorDiaria * desconto;
            }
            return valorfinal;
        }             
    }    
}