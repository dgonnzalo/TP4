using System;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Inscripción");
            Console.WriteLine("Ingrese su numero de registro");
            Alumno alumnoIngresado = Alumno.validarRegistro(); //Valida que el registro ingresado este en la lista, sino alerta que es incorrecto o que se contacte con administracion.
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Alumno: {alumnoIngresado.Nombre} {alumnoIngresado.Apellido} Nro. Registro {alumnoIngresado.Registro}");
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
