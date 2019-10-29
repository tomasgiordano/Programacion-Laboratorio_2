using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Auto:IXML
    {
        public string marca;
        public double precio;

        public Auto():this("",-1)
        {

        }

        public Auto(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public override string ToString()
        {
            return this.marca+" "+this.precio.ToString();
        }

        public bool Guardar(string path)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Auto));
                StreamWriter sw = new StreamWriter(path);
                ser.Serialize(sw, this);
                sw.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Leer(string path, out object salida)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Auto));
                StreamReader sr = new StreamReader(path);
                salida = (Auto)ser.Deserialize(sr);
                return true;
            }
            catch (Exception)
            {
                salida = null;
                return false;
            }
        }
    }
}
