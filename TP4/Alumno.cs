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
        public Alumno(string[] arrayString)  //Constructor a partir de leer archivo
        {
            
            
            bool ciclo = false;
            do
            {
                Registro = int.Parse(arrayString[0]);
                Apellido = arrayString[2];
                Nombre = arrayString[1];
                MateriasAprobadas = arrayString[3]; //Separamos las materias por guion     

                var arrayLista = MateriasAprobadas.Split('-'); //Agarro el string, lo separo por guion, y me queda una lista de las materias aprobadas.
                foreach (var materia in arrayLista) //por cada materia, la agrego a la lista de materias aprobadas, ya parseadas.
                {
                    ListaMateriasAprobadas.Add(int.Parse(materia));
                }
                ciclo = true;
            } while (!ciclo);
                                              

            //tiene que salir un archivo en formato
            //Registro|Apellido|Nombre|MateriasAprobadas
        }

        public Alumno(int registro)
        {
            string ruta = DatosAlumnos.dameRuta();
            bool menuConstructor = false;
            do
            {
                Console.Clear();                            
                if (File.Exists(ruta))
                {
                    StreamReader reader = new StreamReader(ruta);                    
                    while (!reader.EndOfStream)
                    {                        
                        string linea = reader.ReadLine(); //A partir de cada linea, tengo que construir un diccionario, que me permita validar que existe.                    
                        var arraylinea = linea.Split(';');
                        if (int.Parse(arraylinea[0]) == registro)
                        {
                            Alumno alumnoIngresado = new Alumno(arraylinea);
                            Console.WriteLine($"Alumno: {alumnoIngresado.Nombre} {alumnoIngresado.Apellido} Nro. Registro {alumnoIngresado.Registro}");
                            Registro = int.Parse(arraylinea[0]);
                            Apellido = arraylinea[2];
                            Nombre = arraylinea[1];
                            MateriasAprobadas = arraylinea[3]; //Separamos las materias por guion     

                            var arrayLista = MateriasAprobadas.Split('-'); //Agarro el string, lo separo por guion, y me queda una lista de las materias aprobadas.
                            foreach (var materia in arrayLista) //por cada materia, la agrego a la lista de materias aprobadas, ya parseadas.
                            {
                                ListaMateriasAprobadas.Add(int.Parse(materia));
                            }                            
                            menuConstructor = true;
                            
                        }
                        else continue;
                    }
                    
                }
                else Console.WriteLine("Error en la base de datos. Revise la conexion");
            } while (!menuConstructor);
        }
         
        public void inscribir()
        {
           
        }

        public void mostrarMateriasDisponibles() //metodo que muestra las materias que puede cursar
        {
            
        }

       

    }
    
}
