using Seccion7_Herencia;

namespace Seccion7Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutante Mutante1 = new Mutante(true, "Wolverine", "Omega", "Logan", "Canadiense");
            Console.WriteLine(Mutante1.ToString());


            // Instanciamos a la clase "C"
            // Husky Husky1 = new Husky();
            // // Asignamos un valor a la clase "A"
            // Husky1.oxigeno = true;
            // // Asignamos un valor a un campo de la clase "B"
            // Husky1.nombre = "Milo";
            // Husky1.raza = "raza";
            // Console.WriteLine(Husky1.nombre);

            // Salchicha Teckel1 = new Salchicha();
            // Teckel1.acondroplasia = true;
            // Teckel1.nombre = "Salchichon";
            // Console.WriteLine(Teckel1.acondroplasia);
            // Console.WriteLine(Teckel1.nombre);
        }
    }
}