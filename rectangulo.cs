using System;
namespace leccionB
{
    class rectangulo: figura, Ifigura
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public rectangulo(int Base, int Altura, string Nombre, string Color) : base (Nombre, Color)
        {
            this.Nombre = Nombre;
            this.Color = Color;
            this.Base = Base;
            this.Altura = Altura;

        }
        public void calcular_Area(){
            int Area=0;
            Area= Base*Altura;
            Console.WriteLine("El area de un rectangulo es "+Area);
        }
    }
}