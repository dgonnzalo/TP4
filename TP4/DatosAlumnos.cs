using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TP4
{
    static class DatosAlumnos
    {
        const string rutaAlumnos = @""; //Archivo CSV de Alumnos.

        public static bool validarAlumno(int registro) //Si existe el registro,. me devuelve true, sino false.
        {
            bool salirBucle = false;
            bool existeEnRegistro = false; //Retorna true si existe. Utilizar el false en caso de que quiera salir del proceso.

            if (File.Exists(rutaAlumnos))
            {
                do
                {
                    StreamReader reader = new StreamReader(rutaAlumnos);
                    while (!reader.EndOfStream)
                    {
                        string linea = reader.ReadLine(); //A partir de cada linea, tengo que construir un diccionario, que me permita validar que existe.                    
                        var arraylinea = linea.Split(';');
                        if (int.Parse(arraylinea[0]) == registro)
                        {
                            existeEnRegistro = true;
                            Console.WriteLine("El registro ha sido encontrado. Presione cualquier tecla para continuar");
                            Console.ReadKey();
                            salirBucle = true;
                        }
                        if (!existeEnRegistro)
                        {
                            Console.WriteLine("El registro ingresado no existe. Intente de nuevo");
                        }
                    }
                } while (!salirBucle);
            }
            else
            {
                Console.WriteLine("No se ha encontrado la base de datos de Alumnos.CSV");
                Console.ReadKey();
            }
            return existeEnRegistro;
        }


        public static string dameRuta()
            {
                return rutaAlumnos;
            }
    }
}
