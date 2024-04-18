class Caminhao : Veiculo {

    public Caminhao(string m, string mod, int cc) : base(m, mod)
    {
        this.capacidade_carga = cc;
    }

    public int capacidade_carga{set;get;}

    public override void Ligar(){
        Console.WriteLine("Caminhao ligado");
    }
}