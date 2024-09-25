using System.Runtime.ConstrainedExecution;
using desafioHotel.Models;

List<Pessoa> hospedes = new List<Pessoa>();
Pessoa pessoa = new();
Suite suite = new();
Reserva reserva = new();

dynamic numeroDeHospedes;

// recebendo a quantidade de hospedes
Console.WriteLine($"Qual o numero de hospedes?");
numeroDeHospedes = Convert.ToInt32(Console.ReadLine());

// registrando os hospedes na lista de hospedes que será enviada pra Reserva
for( int i = 1; i <= (int)numeroDeHospedes; i++ ){
    Console.WriteLine($"Qual o nome do {i}º hospede?");
    pessoa.Nome = Console.ReadLine();
    Console.WriteLine($"Qual o sobrenome do {i}º hospede?");
    pessoa.Sobrenome = Console.ReadLine();
    hospedes.Add(pessoa);
}

// testando o tipo da suíte e ajustando a capacidade e o valor da diária adequados à suite escolhida
bool suiteCompativel = true;

while (suiteCompativel){
    // recebendo do cliente qual a suite que ele deseja reservar
    Console.WriteLine($"Qual suite você quer?\n 1 - Basic\n 2 - King\n 3 - Deluxe");
    suite.TipoSuite = Console.ReadLine();
    switch (suite.TipoSuite){
    case "1":
        suite.Capacidade = 2;
        suite.ValorDiaria = 100;
        if (suite.Capacidade < numeroDeHospedes){
                Console.WriteLine($"ERRO!! O numero de hospedes excede a capacidade total da suíte!");
                break;
            }
        else{
                suiteCompativel = false;
        }
        break;
    case "2":
        suite.Capacidade = 4;
        suite.ValorDiaria = 200;
        if (suite.Capacidade < numeroDeHospedes){
                Console.WriteLine($"ERRO!! O numero de hospedes excede a capacidade total da suíte!");
                break;
            }
            else{
                suiteCompativel = false;
        }
        break;
    case "3":
        suite.Capacidade = 6;
        suite.ValorDiaria = 300;
        if (suite.Capacidade < numeroDeHospedes){
                Console.WriteLine($"ERRO!! O numero de hospedes excede a capacidade total da suíte!");
                break;
            }
            else{
                suiteCompativel = false;
        }
        break;
    default:
        Console.WriteLine($"Valor Invalido.");
        return;
}
}

// obtendo do cliente de quantos dias será a reserva
Console.WriteLine($"Quantos dias planeja ficar?");
dynamic dias = Convert.ToInt32(Console.ReadLine());

// realizando a reserva
reserva.CadastrarHospedes(hospedes);
reserva.CadastrarSuite(suite);
reserva.DiasReservados = (int)dias;

Console.WriteLine($"Serão {reserva.ObterQuantidadeHospedes()} hospedes e o valor da diaria será R$ {reserva.CalcularValorDiaria()}");
