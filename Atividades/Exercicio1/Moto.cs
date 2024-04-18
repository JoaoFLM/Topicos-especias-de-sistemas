class Moto : Veiculo {

    public Moto(string m, string mod, int cl) : base(m, mod)
    {
        this.cilindrada = cl;
    }
    public int cilindrada{set;get;}

    public override void Ligar(){
        Console.WriteLine("Moto ligada");
    }
}