using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP.classes
{
    public class Persona
    {
        protected string Nombre { get; set; }
        protected int Edad { get; set; }
        protected string Ciudad { get; set; }

        public Persona(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

        public void GetPersonInfo()
        {
            Console.WriteLine($"{Nombre} tiene {Edad} años de edad y vive en {Ciudad}");
        }

        public void GetYearBorn()
        {
            Console.WriteLine($"{Nombre} nació en el año {DateTime.Now.Year - Edad}");
        }
    }
}
