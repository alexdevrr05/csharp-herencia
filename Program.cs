using Seccion7_Herencia;

namespace Seccion7Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mutante Mutante1 = new Mutante();
            // Mutante1.nombre = "Logan";
            // Mutante1.alias = "Wolverine";
            // Console.WriteLine(Mutante1.nombre);
            // Console.WriteLine(Mutante1.alias);

            // Instanciamos a la clase "C"
            Husky Husky1 = new Husky();
            // Asignamos un valor a la clase "A"
            Husky1.oxigeno = true;
            // Asignamos un valor a un campo de la clase "B"
            Husky1.nombre = "Milo";
            Husky1.raza = "raza";
            Console.WriteLine(Husky1.nombre);
        }
    }
}