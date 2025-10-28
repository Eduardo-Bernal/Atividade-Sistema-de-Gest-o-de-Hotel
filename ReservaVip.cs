namespace Atividade_Sistema_de_Gestão_de_Hotel
{
 public class ReservaVip : Reserva
    {
        // Atributo extra
        public double Desconto { get; set; }

        public override double CalcularTotal()
        {
            double totalSemDesconto = base.CalcularTotal();
            double valorDesconto = totalSemDesconto * (Desconto / 100);
            return totalSemDesconto - valorDesconto;
        }

        public override void ResumoReserva()
        {
            Console.WriteLine("*** Resumo da Reserva VIP ***");
            Console.WriteLine($"Hóspede: {Hospede}");
            Console.WriteLine($"Número do Quarto: {Quarto.Numero}");
            Console.WriteLine($"Tipo: {Quarto.Tipo}");
            Console.WriteLine($"Preço da Diária: R${Quarto.PrecoDiaria:F2}");
            Console.WriteLine($"Dias: {Dias}");
            Console.WriteLine($"Desconto: {Desconto}%");
            Console.WriteLine($"Total com Desconto: R${CalcularTotal():F2}");
        }
    }
}