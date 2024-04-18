class Circulo : FiguraGeometrica{
    public double raio {set;get;}
    public double pi {get;}

    public Circulo(double r){
        this.raio = r;
        this.pi = Math.PI;
    }

    public override double CalcularArea(){
        return pi*Math.Pow(raio, 2);
    }
    public override double CalcularPerimetro(){
        return (2*pi)*raio;
    }
    
}