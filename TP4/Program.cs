using System;
using System.IO;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            int registro;
            bool cicloRegistro = false;
            Console.WriteLine("Sistema de inscripción");
            do
            {
                Console.Clear();
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

            Alumno alumnoIngresado = new Alumno(registro);
            Console.Clear();
            bool menuPrincipal = false;
            do
            {
                Console.WriteLine("1. Ver oferta academica. \n2. Inscribite \n9. Salir");
                int numeroMenuPrincipal = Helper.ValidarNumero();
                bool salir = false;
                switch (numeroMenuPrincipal)
                {
                    case 1:
                        //Me muestra todas las ofertas sin validar nada.
                        CursoMateria.ofertaAcademica();
                        Console.WriteLine("Toque cualquier tecla para volver al menu principal");
                        Console.ReadKey();
                        break;

                    case 2:
                        alumnoIngresado.mostrarMateriasDisponibles();
                        alumnoIngresado.inscribir();
                        break;

                    case 9:
                        salir = true;
                        menuPrincipal = true;
                        break;
                } while (!salir);
            } while (!menuPrincipal);
        }
    }
}
