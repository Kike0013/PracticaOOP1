using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP.classes
{
    internal class Estudiante : Persona
    {

        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public Estudiante(string nombre, int edad, string ciudad, string carrera, string matricula)
        : base(nombre, edad, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"{Nombre} es estudiante de la carrera {Carrera}. Matrícula: {Matricula}");
        }
    }
}
