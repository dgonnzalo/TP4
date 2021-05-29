using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TP4
{
    static class CursoMateria
    {
        public static readonly Dictionary<int, string> CursoMateriasOferta;
        const string rutaCursoMateria = @"C:\Users\mateo\source\repos\CAI\TP4\TP4\Materias.csv";
        static CursoMateria()
        {
            //Formato
            //Codigo|Nombre|tipo
            string ruta = @"";
            if (File.Exists(ruta))
            {
                StreamReader reader = new StreamReader(ruta);
                while (!reader.EndOfStream)
                {
                    string linea = reader.ReadLine(); //A partir de cada linea, tengo que construir un diccionario, que me permita validar que existe.
                    var arraylinea = linea.Split(';');
                    int key = int.Parse(arraylinea[0]);
                    string value = arraylinea[1]; //NrodeMateria-NombredeMateria-Docente-Horario-Inicio-Horario-Fin-Dia1-Dia2-Dia3-Sede

                    //var asiento = new CuentasContables(linea); //Constructor con un parametro, es leyendo el archivo
                    CursoMateriasOferta.Add(key,value);
                }

            }
            else Console.WriteLine("No se encontro la Oferta Academica");
            


        }
        public static void dameCurso(int curso)
        {
            var datos = CursoMateriasOferta[curso];
            var linea = datos.Split('-');
            foreach (var datosCurso in linea)
            {
                Console.WriteLine(datosCurso);
            }

        }
        public static void ofertaAcademica()
        {
            foreach (var curso in CursoMateriasOferta)
            {
                var arrayCurso = curso.Value.Split('-');
                foreach (var datosMaterias in arrayCurso)
                {
                    Console.WriteLine($"Numero curso: {curso.Key} - Materia: {datosMaterias[0]} - {datosMaterias[1]} Docente: {datosMaterias[2]} Sede: {datosMaterias[8]}");
                }
            }
        }
    }
}
