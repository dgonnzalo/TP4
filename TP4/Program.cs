using System;
using System.IO;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Inscripción");
            bool existe = false; //Si da true, es que existe el registro ingresado.
            int registro; //Variable que me guarda el registro ingresado.
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese su numero de registro");
                registro = Helper.ValidarNumero();
                existe = DatosAlumnos.validarAlumno(registro);
            } while (!existe);

            Alumno alumnoIngresado = new Alumno(registro);
            bool ciclo = false;
            do
            {
                Console.WriteLine("1. Ver oferta academica. \n2. Inscribite \n9. Salir");
                int numeromenu = Helper.validarNroMenu();
                switch (numeromenu)
                {
                    case 1:
                        CursoMateria.ofertaAcademica(); //Me muestra todas las ofertas sin validar nada.
                        break;

                    case 2:
                        alumnoIngresado.mostrarMateriasDisponibles();
                        alumnoIngresado.inscribir();
                        break;

                    case 9:
                        ciclo = true;
                        break;


                }
            } while (!ciclo);
        }
    }
}
