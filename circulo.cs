using System;
namespace leccionB
{
    class circulo: figura, Ifigura
    {
        public double Pi= 3.1416;
        public double R { get; set; }

        public circulo(double Pi, double Altura, string Nombre, string Color) : base(Nombre,Color)
        {
            this.Nombre = Nombre;
            this.Color = Color;
            this.Pi = Pi;
            this.R = R;

        }
        public void calcular_Area(){
            double Area=0;
            Area= Pi*(R*R) ;
            Console.WriteLine("El area de un circulo es "+Area);

        }
    }
}