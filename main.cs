using System;

abstract class Veiculo
{
    public int Assentos { get; set; }
    public string Placa { get; set; }
    public int Ano { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Veiculo(int assentos, string placa, int ano, string marca, string modelo)
    {
        Assentos = assentos;
        Placa = placa;
        Ano = ano;
        Marca = marca;
        Modelo = modelo;
    }

    public override string ToString()
    {
        return $"Tipo: {GetType().Name}\n" +
               $"Assentos: {Assentos}\n" +
               $"Placa: {Placa}\n" +
               $"Ano: {Ano}\n" +
               $"Marca: {Marca}\n" +
               $"Modelo: {Modelo}\n";
    }
}

class Carro : Veiculo
{
    public Carro(int assentos, string placa, int ano, string marca, string modelo)
        : base(assentos, placa, ano, marca, modelo)
    {
    }
}

class Onibus : Veiculo
{
    public Onibus(int assentos, string placa, int ano, string marca, string modelo)
        : base(assentos, placa, ano, marca, modelo)
    {
    }
}

class Caminhao : Veiculo
{
    public int NumeroDeEixos { get; set; }

    public Caminhao(int assentos, string placa, int ano, string marca, string modelo, int numeroDeEixos)
        : base(assentos, placa, ano, marca, modelo)
    {
        NumeroDeEixos = numeroDeEixos;
    }

    public override string ToString()
    {
        return base.ToString() + $"Número de Eixos: {NumeroDeEixos}\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var carro = new Carro(4, "ABC123", 2022, "Ford", "Fiesta");
        var onibus = new Onibus(20, "XYZ456", 2020, "Mercedes-Benz", "Tourismo");
        var caminhao = new Caminhao(2, "DEF789", 2021, "Volvo", "FH16", 8);

        Console.WriteLine(carro);
        Console.WriteLine(onibus);
        Console.WriteLine(caminhao);
    }
}
