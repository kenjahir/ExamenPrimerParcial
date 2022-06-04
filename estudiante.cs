using System;

namespace ExamenPrimerParcial
{
    class estudiante
    {
        string nombre { get; set; }
        string apellido { get; set; }
        string institucion { get; set; }
        int identificacion { get; set; }

        public class alumnos (string nombre, string apellido, string institucion, int identificacion)
            {
             
                 this.nombre =nombre;
                 this.apellido = apellido;
                 this.identicacion = identificacion;

            }
    }
}