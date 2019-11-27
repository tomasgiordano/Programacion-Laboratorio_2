using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class AstroExtension
    {
        public static bool GuardarPlanTxt(this Planeta<Satelite> plan)
        {

            try
            {
                using (StreamWriter sw = File.AppendText("planeta.txt"))
                {
                    sw.WriteLine(plan.ToString());
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar archivo .txt", e);
            }

            return true;
        }

        public static bool GuardarXML(this Satelite sat)
        {

            try
            {
                XmlSerializer s = new XmlSerializer(typeof(Satelite));

                using (XmlTextWriter xw = new XmlTextWriter("satelites.xml", Encoding.UTF8))
                {
                    xw.Formatting = Formatting.Indented;
                    s.Serialize(xw, sat);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al serializar archivo .xml", e);
            }
            return true;

        }
    }
}
