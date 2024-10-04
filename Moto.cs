public class Moto : Veiculo
{
    private bool TemBagageiro;

    public Moto(string marca, string modelo, int ano, bool TemBagageiro)
    :base(marca, modelo, ano)
    {
        this.TemBagageiro = TemBagageiro;
    }

    public void DarGrau()
    {
        Console.WriteLine("Ramdamdamdam PA PA PA");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano: {ano}");

    }
}