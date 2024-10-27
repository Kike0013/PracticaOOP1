using PracticaOOP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Abel", 20, "Metropolandia");
            Estudiante estudiante = new Estudiante("Abel", 20, "Metropolandia", "Ingeniería Informática", "2-14-8461");
            Figura rectangulo = new Rectangulo(5, 10);
            Figura circulo = new Circulo(7);
            Figura triangulo = new Triangulo(6, 8);

            Console.WriteLine("1. Creación de una clase:\n");

            persona.GetPersonInfo();
            persona.GetYearBorn();

            Console.WriteLine("\n2. Implementación de Herencia:\n");

            estudiante.StudentInfo();

            Console.WriteLine("\n3. Implementación de Polimorfismo:\n");

            Console.WriteLine($"Área del Rectángulo: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Área del Círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Área del Triángulo: {triangulo.CalcularArea()}");

            Console.ReadKey();
        }
    }
}
