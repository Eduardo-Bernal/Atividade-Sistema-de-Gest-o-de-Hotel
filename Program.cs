namespace Atividade_Sistema_de_Gestão_de_Hotel;

class Program
{
    static void Main(string[] args)
    {
        List<Reserva> reservas = new List<Reserva>();


Quarto q1 = new Quarto { Numero = 07, Tipo = "Simples", PrecoDiaria = 200, Disponivel = true };
Quarto q2 = new Quarto { Numero = 17, Tipo = "Suíte", PrecoDiaria = 400, Disponivel = true };


Reserva reservaNormal = new Reserva
{
    Hospede = "Eduardo",
    Quarto = q1,
    Dias = 3
};

ReservaVip reservaVip = new ReservaVip
{
    Hospede = "Mayara",
    Quarto = q2,
    Dias = 5,
    Desconto = 10 
};


reservas.Add(reservaNormal);
reservas.Add(reservaVip);


foreach (var r in reservas)
{
    r.ResumoReserva();
    Console.WriteLine();
}
    }
}
