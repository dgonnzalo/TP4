using System;
using System.IO;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            int registro = inscripcion.ingreso();
            Alumno alumnoIngresado = new Alumno(registro);
            
            Console.Clear();
            bool menuPrincipal = false;
            do
            {
                int numeroMenuPrincipal = inscripcion.mostrarMenu();                                
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
                        //alumnoIngresado.inscribir();
                        break;

                    case 9:
                        salir = true;
                        menuPrincipal = true;
                        break;
                } while (!salir) ;
            } while (!menuPrincipal);            
        }
    }
}
