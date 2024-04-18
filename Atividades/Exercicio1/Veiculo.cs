class Veiculo{

    public Veiculo(string m, string mod){
        this.marca = m;
        this.modelo = mod;
    }
    public string marca{set;get;}
    public string modelo{set;get;}

    public virtual void Ligar(){
        Console.WriteLine("Veiculo ligado");
    }
}