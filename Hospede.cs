
namespace Atividade_Sistema_de_Gestão_de_Hotel
{
public class Hospede
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Telefone { get; set; }


    public Hospede(string nome, string cpf, string telefone)
    {
        Nome = nome;
        CPF = cpf;
        Telefone = telefone;
    }

    public void ExibirInformacoes()
        {
        Console.WriteLine("*** Informacoes do Hospede");
        Console.WriteLine($"Nome: {Nome}\nCPF: {CPF}\nTelefone: {Telefone}");
    }
}
}