using System;
using System.Collections.Generic;
using System.Text;

namespace TP4
{
    class Alumno
    {
        //Propiedades
        public int Registro { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string MateriasAprobadas { get; set; }
        public List<int> ListaMateriasAprobadas { get; set; }


        //Constructores
        public Alumno(string EntradaArchivo, int RegistroIngresado)  //Constructor a partir de leer archivo
        {
            //Formato Recibido:
            //REGISTRO(INT)|NOMBRE(STRING)|APELLIDO(STRING)|MATERIASAPROBADAS(STRING)
            
            var arrayString = EntradaArchivo.Split(';');
            bool ciclo = false;
            do
            {
                if (int.Parse(arrayString[0]) == Registro)
                {
                    if (int.TryParse(arrayString[0], out int nroRegistroParseado))
                    {
                        Registro = nroRegistroParseado;
                        Apellido = arrayString[2];
                        Nombre = arrayString[1];
                        MateriasAprobadas = arrayString[3]; //Separamos las materias por guion     

                        var arrayLista = MateriasAprobadas.Split('-'); //Agarro el string, lo separo por guion, y me queda una lista de las materias aprobadas.
                        foreach (var materia in arrayLista) //por cada materia, la agrego a la lista de materias aprobadas, ya parseadas.
                        {
                            ListaMateriasAprobadas.Add(int.Parse(materia));
                        }
                        ciclo = true;
                    }

                }
                else
                {
                    Console.WriteLine("Registro no encontrado. Consulte con el administrador o intente de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!ciclo);

            //tiene que salir un archivo en formato
            //Registro|Apellido|Nombre|MateriasAprobadas
        }
        public 
        public void inscribir()
        {
            CursoMateria.dameCurso(numeroCurso);
        }

        private void mostrarMateriasDisponibles() //metodo que muestra las materias que puede cursar
        {
            foreach (var totalMaterias in CursoMateria.OfertaAcademica)
            {

            }
        }

    }
    
}
