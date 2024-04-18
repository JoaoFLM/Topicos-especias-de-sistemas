class Vendedor : Funcionario{
    public decimal Comisao{get;set;}
    public string Area_atuacao{get;set;}

    public string Nivel_experiencia{get;set;}

    public Vendedor(string n, decimal s, decimal com, string aat, string nivel) : base(n, s){
        this.Comisao = com;
        this.Area_atuacao = aat;
        this.Nivel_experiencia = nivel;
    }
}