using Seccion7_Herencia;

namespace Seccion7Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutante Mutante1 = new Mutante();
            Mutante1.nombre = "Logan";
            Mutante1.alias = "Wolverine";
            Console.WriteLine(Mutante1.nombre);
            Console.WriteLine(Mutante1.alias);
        }
    }
}