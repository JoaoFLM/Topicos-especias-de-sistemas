class Carro : Veiculo {

    public Carro(string m, string mod, int np) : base(m, mod)
    {
        this.numero_portas = np;
    }

    public int numero_portas{get;set;}

    public override void Ligar(){
        Console.WriteLine("Carro ligado");
    }
}