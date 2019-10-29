using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();

            Persona P1 = new Persona("Tomas", "Giordano",18);
            P1.GetApodos.Add("Gio");
            Persona P2 = new Persona("Nicolas", "Pantano",18);
            P2.GetApodos.Add("Nico");
            Persona P3 = new Persona("Carlos", "Castro",19);
            P3.GetApodos.Add("nYa");

            lista.Add(P1);
            lista.Add(P2);
            lista.Add(P3);

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                //XmlTextWriter tw = new XmlTextWriter();
                StreamWriter sw = new StreamWriter("Persona.xml");
                ser.Serialize(sw,P1);
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                StreamReader sr = new StreamReader("Persona.xml");

                Persona p = new Persona();

                p = (Persona)ser.Deserialize(sr);
                Console.WriteLine(p.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Persona>));
                StreamWriter sw = new StreamWriter("Lista.xml");
                ser.Serialize(sw, lista);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
