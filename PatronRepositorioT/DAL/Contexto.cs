using PatronRepositorioT.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorioT.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cuentas> Cuentas { get; set; }

        public Contexto() : base("Constr") { }
    }
}
