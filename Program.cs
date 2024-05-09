

using Semana3A2;
public class Program
{

static void Main(string[] args)
{
    Televisor terevi = new Televisor("sony", "Bravia", 55);

    Domicilio domicilio = new Domicilio("Jonte", 5299, "Monte Castro");

    Persona camila = new Persona("Camila", domicilio, terevi);

    Persona facundo = new Persona("Facundo", domicilio, terevi);



    //Console.WriteLine($"Estado inicial del televisor {terevi.Estado}");

    Console.WriteLine(camila);

    terevi.cambiarEstado();

    Console.WriteLine($"Canal sintonizado por defecto 'Locomotion': {terevi.obtenerCanalActual()}");


    
}


}







