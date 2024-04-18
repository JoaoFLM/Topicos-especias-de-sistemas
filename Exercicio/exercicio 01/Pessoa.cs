public class Pessoa{
    
    public string CPF{get;set;}
    public string nome{get;set;}

    List<Livro> livros = new List<Livro>();
    public Pessoa(string cpf, string n){
        this.CPF = cpf;
        this.nome = n;
    }
    public void receberLivros(Livro l){
        this.livros.Add(l);
    }
    public void mostrarInformacoes(){
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("CPF: " + this.CPF);

        foreach(Livro aux in this.livros){
            Console.WriteLine("*****Livros*****");
            Console.WriteLine("Livro: " + aux.titulo);
            Console.WriteLine("Livro: " + aux.autor);
        }        
        
    }

}