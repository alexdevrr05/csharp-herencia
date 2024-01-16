namespace Seccion7_Herencia
{
    public class Humano
    {
        public string nombre, genero, nacionalidad, ocupacion;
        public double statura;
        public int edad;

        public Humano(string nombrePa, string nacionalidadPa)
        {
            nombre = nombrePa;
            nacionalidad = nacionalidadPa;
        }
    }
}