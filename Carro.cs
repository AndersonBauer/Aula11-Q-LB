public class Carro : Veiculo
{
    private int numPortas;
    

    public Carro(string marca, string modelo, int ano, int numPortas)
    :base(marca, modelo, ano)
    {
        this.numPortas = numPortas;
    }
    public void AbrirPortaMalas()
    {
        Console.WriteLine("O porta malas esta aberto! ");
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano: {ano}, Némero de portas: {numPortas}");

    }
}