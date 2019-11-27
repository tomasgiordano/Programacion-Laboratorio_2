using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos) {
            try
            {
                using (XmlTextWriter xmlWriter = new XmlTextWriter("D:\\" + archivo + ".xml", Encoding.UTF8)) {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(xmlWriter, datos);
                }
            }
            catch (Exception e) {
                throw new Exception("Error al serializar en XML", e);
            }
        }

        public void Leer(string archivo, out T datos) {
            T aux;

            try
            {
                using (XmlTextReader xmlReader = new XmlTextReader("D:\\" + archivo + ".xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    aux = (T)xmlSerializer.Deserialize(xmlReader);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al serializar en XML", e);
            }

            datos = aux;
        }

    }
}
