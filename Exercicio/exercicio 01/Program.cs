Livro l1 = new Livro("Livro Legal 01", "Autor legal 01");

Pessoa p1 = new Pessoa("000.000.000-00", "Pessoa Legal 01");

p1.receberLivros(l1);

Livro l2 = new Livro("Livro Ruim 01", "Autor Ruim 02");

p1.receberLivros(l2);

p1.mostrarInformacoes();
