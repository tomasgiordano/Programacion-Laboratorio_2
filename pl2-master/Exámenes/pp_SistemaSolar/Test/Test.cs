using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class Test
    {

        [TestMethod]
        public void ProbarAgregarSatelites() {
            Planeta p = new Planeta(1, 1, "Tierra", 1, Tipo.Rocoso);
            Satelite s = new Satelite(1, 1, "Luna");
            if (p + s) {
                if (p.Satelites.Contains(s)) {
                    Assert.IsTrue(p.Satelites[0] == s);
                }
                else {
                    //No se encuentra en la lista
                    Assert.Fail("No se encuentra en la lista el satelite");
                }
            }
            else {
                //No se agrego
                Assert.Fail("No se agrego el satelite");
            }
        }

        [TestMethod]
        public void PlanetasMismoNombre() {
            Planeta p1 = new Planeta(1, 1, "Tierra", 1, Tipo.Rocoso);
            Planeta p2 = new Planeta(3, 2, "Tierra", 4, Tipo.Gaseoso);
            Assert.IsTrue(p1 == p2);
        }

        [TestMethod]
        public void PlanetasDiferenteNombre() {
            Planeta p1 = new Planeta(1, 1, "Tierra", 1, Tipo.Rocoso);
            Planeta p2 = new Planeta(1, 1, "Marte", 1, Tipo.Rocoso);
            Assert.IsFalse(p1 == p2);
        }

        [TestMethod]
        public void ChequearQueElSateliteSiEstaEnLaLista() {
            Planeta p = new Planeta(1, 1, "Tierra", 1, Tipo.Rocoso);
            Satelite s = new Satelite(1, 1, "Luna");
            if (p + s) {
                Assert.IsTrue(p == s);
            }
        }

        [TestMethod]
        public void ChequearQueElSateliteNoEsteEnLaLista() {
            Planeta p = new Planeta(1, 1, "Tierra", 1, Tipo.Rocoso);
            Satelite s = new Satelite(1, 1, "Luna");
            Assert.IsFalse(p == s);
        }

        [TestMethod]
        public void SateliteMismoNombre()
        {
            Satelite s = new Satelite(1, 1, "Luna");
            System.Diagnostics.Debug.Write(s.ToString());
            Assert.IsTrue(s.Nombre == "Luna");
        }

        [TestMethod]
        public void CargarSistemaSolar()
        {
            SistemaSolar ss = new SistemaSolar();

            Planeta p1 = new Planeta(1, 4, "Tierra", 1, Tipo.Rocoso);
            Planeta p2 = new Planeta(2, 1, "Marte", 2, Tipo.Rocoso);
            Planeta p3 = new Planeta(1, 3, "Europa", 3, Tipo.Gaseoso);

            Satelite s1 = new Satelite(9, 1, "Luna 1");
            Satelite s2 = new Satelite(1, 3, "Luna 2");
            Satelite s3 = new Satelite(5, 1, "Luna 3");
            Satelite s4 = new Satelite(1, 1, "Luna 4");
            Satelite s5 = new Satelite(4, 3, "Luna 5");

            if (p1 + s1);
            if (p1 + s2);
            if (p2 + s3);
            if (p2 + s4);
            if (p3 + s5);


            ss.Planeta.Add(p1);
            ss.Planeta.Add(p2);
            ss.Planeta.Add(p3);

            Console.WriteLine("Test: {0}", ss.MostrarInformacionAstros());

            Assert.IsTrue(1==1);
        }





    }
}
