namespace Seccion7_Herencia
{
    // Se lee: Mutante is a Humano
    public class Mutante : Humano
    {
        public bool genX;
        public string alias, clasificacion;

        // funciona como intermediario entre la clase base y la clase derivada
        public Mutante(bool genxPa, string aliasPa, string clasificacionPa,
         string nombrePa, string nacionalidadPa) : base(nombrePa, nacionalidadPa)
        {
            genX = genxPa;
            alias = aliasPa;
            clasificacion = clasificacionPa;
        }

        public string ToString()
        {
            return String.Format("Nombre: {0} \nNacionalidad: {1} \nAlias: {2} \nClasificacion: {3} \nGen X: {4}", nombre, nacionalidad, alias, clasificacion, genX);
        }
    }

}

// class ClaseDerivada : ClaseBase 
