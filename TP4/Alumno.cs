using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TP4
{
    class Alumno
    {
        //Propiedades
        public int Registro { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private string MateriasAprobadas { get; set; }
        public List<int> ListaMateriasAprobadas { get; set; }


        //Constructores      

        public Alumno(int registro)
        {
            string ruta = DatosAlumnos.dameRuta();           
            if (File.Exists(ruta))
            {
                StreamReader reader = new StreamReader(ruta);
                while (!reader.EndOfStream)
                {
                    string linea = reader.ReadLine(); //A partir de cada linea, tengo que construir un diccionario, que me permita validar que existe.                    
                    var arraylinea = linea.Split(';');
                    if (int.Parse(arraylinea[0]) == registro)
                    {
                        Registro = int.Parse(arraylinea[0]);
                        Apellido = arraylinea[2];
                        Nombre = arraylinea[1];
                        MateriasAprobadas = arraylinea[4]; //Separamos las materias por guion     

                        var arrayLista = MateriasAprobadas.Split(','); //Agarro el string, lo separo por guion, y me queda una lista de las materias aprobadas.
                        foreach (var materiasSegunRegistro in arrayLista) //por cada materia, la agrego a la lista de materias aprobadas, ya parseadas.
                        {
                            int parseado;
                            if (!int.TryParse(materiasSegunRegistro, out parseado))
                            {
                                continue;
                            }
                            else
                            {
                                ListaMateriasAprobadas.Add(parseado);
                            }

                        }
                    }
                    else continue;
                }
                
            }
            else Console.WriteLine("Error en la base de datos. Revise la conexion");
        }

    }
}
    
