using System;
using System.Collections.Generic;
using System.Text;

namespace TP4
{
    static class inscripcion
    {
        public static int ingreso()
        {
            int registro;
            bool cicloRegistro = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de inscripción");
                Console.WriteLine("Favor de ingresar su registro");
                registro = Helper.ValidarNumero();
                if (!DatosAlumnos.validarAlumno(registro))//Si el registro del alumno no existe, preguntar que desea
                {
                    Console.WriteLine("Registro no encontrado. Presione 1 para intentar de nuevo. 9 para salir");
                    int answer = Helper.ValidarNumero(); //Arreglar validaciones de opciones
                    if (answer == 9) //rompo el ciclo porque quiere salir.
                        cicloRegistro = true;

                }
                else
                {
                    Console.WriteLine("Registro ingresado correctamnete");
                    cicloRegistro = true;
                    Console.ReadKey();
                }
            } while (!cicloRegistro);
            return registro;
        } 
        public static int mostrarMenu() //Ojo que si ingresar un numero incorrecto, rompe.
        {
            Console.WriteLine("1. Ver oferta academica. \n2. Inscribite \n9. Salir");
            int opcion = Helper.validarNroMenu();
            return opcion;
        }
        public static void inscribirAlumno()
        {

        }
    }
}
