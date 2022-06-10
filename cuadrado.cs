using System;
namespace leccionB
{
    class cuadrado: figura, Ifigura
    {
        public int lados1 { get; set; }
        public int lados2 { get; set; }
        public int lados3 { get; set; }
        public int lados4 { get; set; }

        public cuadrado(int lados1, int lados2, int lados3, int lados4, string Nombre, string Color) : base(Nombre,Color)
        {
             this.Lado1 = Lado1;
             this.Lado2 = Lado2;
             this.Lado3 = Lado3;
             this.Lado4 = Lado4;
        }

        public void calcular_Area(){
            int suma;
            suma=lado1+lado2+lado3+lado4;
            Console.WriteLine($"tiene "+suma+ "lados");
        }
    }
}