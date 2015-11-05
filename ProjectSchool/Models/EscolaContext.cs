using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectSchool.Models
{
    public class EscolaContext : DbContext
    {
        public EscolaContext()
            : base("SQLServerConnection")
        {

        }
        public DbSet<AlunoModel> Alunos { get; set; }
        public DbSet<MateriaLecionadaModel> MateriasLecionadas { get; set; }
        public DbSet<MateriaModel> Materias { get; set; }
        public DbSet<MateriaLecionadaModel> MateriasLecionadas { get; set; }        

    }
}