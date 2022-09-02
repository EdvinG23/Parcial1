using System;
using System.Collections;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {

            int Rps;
            do
            {
            int numberStudents;
            ArrayList registro = new ArrayList();
            string nombre;
            int edad;
            double nota1;
            double nota2;
            double parcial1;
            double notaFinal;
            int contador = 0;

            Console.WriteLine("Ingrese el numero de estudiantes a evaluar: ");
            numberStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("");
                while (contador < numberStudents)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese la edad del estudiante: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del Lab #1 del estudiante: ");
                    nota1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del Lab #2 del estudiante: ");
                    nota2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del parcial #1 del estudiante: ");
                    parcial1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("La nota final es de: ");
                    notaFinal = (nota1 * .3)+(nota1 * .3)+(parcial1 * .4);
                    Console.WriteLine("");

                    Students students = new Students() { Nombre = nombre, Edad = edad, Nota1 = nota1, Nota2 = nota2, Parcial1 = parcial1, Notafinal = notaFinal };
                    registro.Add(students);

                    contador++;
                }
                Console.WriteLine(" --- LISTA FINAL --- ");
                foreach (Students st in registro)
                {
                    Console.WriteLine(st.getData());
                }

                Console.WriteLine("¿Desea continuar? Presione un numero cualquiera -- ¿Desea finalizar? Ingrese 1");
                Rps = Convert.ToInt32(Console.ReadLine());

            } while (Rps != 1);
            Console.WriteLine("A finalizado");

        }
    }

    public class Students
    {

        private string _nombre;
        private int _edad;
        private double _nota1;
        private double _nota2;
        private double _parcial1;
        private double _notaFinal;
        public string Nombre
        {

            get => _nombre;
            set => _nombre = value;

        }

        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }

        public double Nota1
        {
            get => _nota1;
            set => _nota1 = value;
        }

        public double Nota2
        {
            get => _nota2;
            set => _nota2 = value;
        }

        public double Parcial1
        {
            get => _parcial1;
            set => _parcial1 = value;
        }


        public double Notafinal { get; internal set; }
  
        public string getData()
        {
            return "Nombre: " + _nombre + " Edad: " + _nota2 + " Nota1: " + _nota1 + " Nota2: " + _nota2 + " Parcial1: " +_parcial1 + " NotaFinal: " + _notaFinal;
        }


    }

}