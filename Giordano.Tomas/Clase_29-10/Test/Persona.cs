using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Test
{   
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]
    public class Persona:IXML
    {
        public string nombre;
        public string apellido;
        private int edad;
        List<string> apodos;

        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public List<String> GetApodos { get { return this.apodos; } }

        public Persona() : this("", "", 0)
        {

        }
        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            apodos = new List<string>();
        }

        public override string ToString()
        {
            return this.nombre + " " + this.apellido + " " + this.edad;
        }

        public bool Guardar(string path)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                StreamWriter sw = new StreamWriter(path);
                ser.Serialize(sw,this);
                sw.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Leer(string path,out object salida)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                StreamReader sr = new StreamReader(path);
                salida = (Persona)ser.Deserialize(sr);
                return true;
            }
            catch(Exception)
            {
                salida = null;
                return false;
            }
        }
     }
}
