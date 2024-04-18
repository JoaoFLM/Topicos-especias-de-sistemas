class Quadrado : FiguraGeometrica{
    public double lado1{set;get;}
    public double lado2{set;get;}

    public Quadrado(double x, double y){
        this.lado1 = x;
        this.lado2 = y;
    }

    public override double CalcularArea(){
        return this.lado1*this.lado2;
    }
    public override double CalcularPerimetro(){
        return this.lado1+this.lado2;
    }
    
}