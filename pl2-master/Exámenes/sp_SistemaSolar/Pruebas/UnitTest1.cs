using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Entidades;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GuardarLeerSQL()
        {

            SateliteDB sql = new SateliteDB();

            Satelite sat = new Satelite(133, 111, "Luna");

            List<Satelite> satList = new List<Satelite>();

            if (sql.Guardar(sat))
            {
                satList = sql.Leer();
            }
            else {
                Assert.Fail("Error al guardar en la base de datos");
            }

            Assert.IsTrue(
                sat.Nombre == satList[0].Nombre &&
                sat.DuraOrbita == satList[0].DuraOrbita &&
                sat.DuraRotacion == satList[0].DuraRotacion);


        }
    }
}
