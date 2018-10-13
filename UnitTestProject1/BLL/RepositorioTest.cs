using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorioT.BLL;
using PatronRepositorioT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.BLL
{
    [TestClass()]
    public class RepositorioTest
    {
        [TestMethod()]
        public void Guardar()
        {
            Cuentas cuentas = new Cuentas();
            cuentas.CuentaId = 0;
            cuentas.Descripcion = "Cuenta Luiso";
            RepositorioBase<Cuentas> repositorio;
            repositorio = new RepositorioBase<Cuentas>();
            Assert.IsTrue(repositorio.Guardar(cuentas));
        }
    }
}
