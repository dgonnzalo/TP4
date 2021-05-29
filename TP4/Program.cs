using System;
using System.IO;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"";            
            Console.WriteLine("Sistema de Inscripción");
            Console.WriteLine("Ingrese su numero de registro");
            bool menu = false;
            do
            {
                int registro = Helper.ValidarNumero();
                if (File.Exists(ruta))
                {
                    Alumno alumnoIngresado = new Alumno(ruta ,registro);
                    Console.WriteLine($"Alumno: {alumnoIngresado.Nombre} {alumnoIngresado.Apellido} Nro. Registro {alumnoIngresado.Registro}");
                    menu = true;

                }
                else Console.WriteLine("Base de datos no pudo ser leida.")
;            } while (!menu);
            Console.ReadKey();
            Console.Clear();           
            Console.WriteLine("1. Ver oferta academica. \n2. Inscribite \n9. Salir");
            bool ciclo = false;
            int menu = Helper.validarNroMenu();
            do
            {
                switch (menu)
                {
                    case 1:
                        CursoMateria.ofertaAcademica(); //Me muestra todas las ofertas sin validar nada.
                        break;

                    case 2:
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
