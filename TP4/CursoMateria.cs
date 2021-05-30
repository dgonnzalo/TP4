using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TP4
{
    static class CursoMateria
    {
        //      0               1             2             3        4          5        6
        //Nro de Curso;Nro de Materia;Nombre de Materia;Docente;Dia y Horario;Sede; Correlativas(separadas por '-')         
        const string rutaCursoMateria = @"C:\Users\mateo\source\repos\CAI\TP4\TP4\Materias.csv";
        public static List<Curso> TotalCursos = new List<Curso>();
        
        static CursoMateria()
        {
            //Formato
            //Codigo|Nombre|tipo           
            if (File.Exists(rutaCursoMateria))
            {
                using (StreamReader reader = new StreamReader(rutaCursoMateria))
                {
                    while (!reader.EndOfStream)
                    {
                        string linea = reader.ReadLine(); //A partir de cada linea, tengo que construir un diccionario, que me permita validar que existe.                                     
                        Curso cursada = new Curso(linea);
                        TotalCursos.Add(cursada);
                    }
                }

            }
            else
            {
                Console.WriteLine("No se encontro la Oferta Academica");
                Console.ReadKey();
            }
            


        }
        public static void ofertaAcademica()
        {
            foreach (var curso in TotalCursos)
            {
                Console.WriteLine($"Numero curso:{curso.NumeroCurso}, {curso.NombreDeMateria},Docente: {curso.Docente} dia y horario: {curso.DiayHorario} en {curso.Sede}");

            }
            Console.ReadKey();
        }


    }
}
