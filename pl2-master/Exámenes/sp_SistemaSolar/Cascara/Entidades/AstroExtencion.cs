using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public static class AstroExtencion
    {
        static bool GuardarPlanTxt(this Planeta<Satelite> plan)
        {
            try
            {
                StreamWriter sw = new StreamWriter("planeta.txt");
                sw.WriteLine(plan.ToString());
                sw.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        static bool GuardarXML(this Satelite sat)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Satelite));
                StreamWriter sw = new StreamWriter("satelites.xml");
                ser.Serialize(sw,sat);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
