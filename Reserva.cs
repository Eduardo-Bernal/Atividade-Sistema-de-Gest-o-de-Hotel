namespace Atividade_Sistema_de_Gestão_de_Hotel
{
    public class Reserva
    {
        
        public string Hospede { get; set; } = string.Empty;
        public Quarto Quarto { get; set; } = new Quarto();
        public int Dias { get; set; }

        
        public virtual double CalcularTotal()
        {
            return Quarto.PrecoDiaria * Dias;
        }

      
        public virtual void ResumoReserva()
        {
            Console.WriteLine("*** Resumo da Reserva ***");
            Console.WriteLine($"Hóspede: {Hospede}");
            Console.WriteLine($"Número do Quarto: {Quarto.Numero}");
            Console.WriteLine($"Tipo: {Quarto.Tipo}");
            Console.WriteLine($"Preço da Diária: R${Quarto.PrecoDiaria:F2}");
            Console.WriteLine($"Dias: {Dias}");
            Console.WriteLine($"Total a Pagar: R${CalcularTotal():F2}");
    
        }
    }
}