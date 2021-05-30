using System;
using System.Collections.Generic;
using System.Text;

namespace TP4
{
    class Curso
    {
        //Propiedades
        public int NumeroCurso { get; set; }
        public int NumeroMateria { get; set; }
        public string NombreDeMateria { get; set; }
        public string Docente { get; set; }
        public string DiayHorario { get; set; }
        public string Sede { get; set; }       
        public List<int> Correlativas { get; set; }

        //Constructores
        public Curso(string linea)
        {
            //      0               1             2             3        4          5        6
            //Nro de Curso;Nro de Materia;Nombre de Materia;Docente;Dia y Horario;Sede; Correlativas(separadas por '-') 
            
            var datosCursoArray = linea.Split(';');
            NumeroCurso = int.Parse(datosCursoArray[0]);
            NumeroMateria = int.Parse(datosCursoArray[1]);
            NombreDeMateria = datosCursoArray[2];
            Docente = datosCursoArray[3];
            DiayHorario = datosCursoArray[4];
            Sede = datosCursoArray[5];
            var lineaCorrelativas = datosCursoArray[6];
            var arrayCorrelativas = lineaCorrelativas.Split('-');
            foreach (var correlativa in arrayCorrelativas)
            {
                int correlativaParseada = int.Parse(correlativa);
                Correlativas.Add(correlativaParseada);
            }
        }

    }
}
