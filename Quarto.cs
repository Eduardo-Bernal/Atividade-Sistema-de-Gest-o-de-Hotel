namespace Atividade_Sistema_de_Gestão_de_Hotel
{
public class Quarto
    {

        public int Numero { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public double PrecoDiaria { get; set; }
        public bool Disponivel { get; set; } = true;

  
        public void ExibirDetalhes()
        {
            Console.WriteLine("*** Informacoes do Quarto ***");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Preço da diária: R${PrecoDiaria:F2}");

            if (Disponivel)
            {
                Console.WriteLine("Status: Disponível para Alugar");
            }
            else
            {
                Console.WriteLine("Status: Ocupado! (Indisponível)");
            }
        }

        public void Ocupar()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine($"Quarto: {Numero} foi ocupado.");
            }
            else
            {
                Console.WriteLine($"Quarto: {Numero} já está ocupado!");
            }
        }

        public void Liberar()
        {
            if (!Disponivel)
            {
                Disponivel = true;
                Console.WriteLine($"Quarto: {Numero} foi liberado.");
            }
            else
            {
                Console.WriteLine($"Quarto: {Numero} já está disponível!");
            }
        }
    }
}
