using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            try {
                using (StreamWriter sw = new StreamWriter("D:\\" + archivo + ".txt"))
                {
                    foreach (Patente p in datos)
                    {
                        sw.WriteLine(p.ToString());
                    }
                }
            }
            catch (Exception e) {
                throw new Exception("Error al guardar el archivo de texto", e);
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            Queue<Patente> patentesAux = new Queue<Patente>();

            try {
                using (StreamReader sr = new StreamReader("D:\\" + archivo + ".txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        patentesAux.Enqueue(PatenteStringExtension.ValidarPatente(sr.ReadLine()));
                    }
                }
            }
            catch (Exception e) {
                throw new Exception("Error al leer archivo de texto", e);
            }


            datos = patentesAux;
        }
    }
}
