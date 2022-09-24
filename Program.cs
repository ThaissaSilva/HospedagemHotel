using System.Text;
using HospedagemHotel.Models;

Console.OutputEncoding = Encoding.UTF8;


//cria os modelos de hospedes e cadastra na lista de hospedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

//cria a suite
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 100);

//cria uma nova reserva, passando a suite e os Hóspedes
Reserva reserva = new Reserva(diasReservados: 2);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQtdHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");