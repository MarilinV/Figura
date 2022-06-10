using System;
namespace leccionB
{
    class figura
    {
        public string Nombre { get; set; }
        public string Color { get; set; }

        public figura(string Nombre, string Color)
        {
            this.Nombre = Nombre;
            this.Color = Color;
        }
        public void Imprimir()
        {
            Console.WriteLine("El nombre de la figura es: " +Nombre);
            Console.WriteLine("El color de la figura es: " +Color);
        }
    }
}
