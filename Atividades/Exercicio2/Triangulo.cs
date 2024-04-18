    class Triangulo : FiguraGeometrica{
        public double base_triangulo{set;get;}
        public double lado1{set;get;}
        public double lado2{set;get;}
        public double altura{set;get;}

        public Triangulo(double bt, double l1, double l2, double al){
            this.base_triangulo = bt;
            this.lado1 = l1;
            this.lado2 = l2;
            this.altura = al;
        }
        public override double CalcularArea(){
            return (this.base_triangulo*this.altura)/2;
        }
        public override double CalcularPerimetro(){
            return (this.lado1+this.lado2+this.base_triangulo);
        }
    }