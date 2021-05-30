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
        public static readonly List<string> ofertaMaterias = new List<string>();
        const string rutaCursoMateria = @"C:\Users\mateo\source\repos\CAI\TP4\TP4\Materias.csv";
        static CursoMateria()
        {
            //Formato
            //Codigo|Nombre|tipo           
            if (File.Exists(rutaCursoMateria))
            {
                StreamReader reader = new StreamReader(rutaCursoMateria);
                while (!reader.EndOfStream)
                {
                    string linea = reader.ReadLine(); //A partir de cada linea, tengo que construir un diccionario, que me permita validar que existe.
                    ofertaMaterias.Add(linea);
                }

            }
            else Console.WriteLine("No se encontro la Oferta Academica");
            


        }
        public static void ofertaAcademica()
        {
            foreach (var curso in ofertaMaterias)
            {
                var arrayCursos = curso.Split(';');
                Console.WriteLine("");
                Console.WriteLine($"Curso numero:{arrayCursos[0]} Materia: {arrayCursos[2]} Profesor: {arrayCursos[3]} Dia y Horario:{arrayCursos[4]} en Sede:{arrayCursos[5]}");

            }

        }
    }
}
