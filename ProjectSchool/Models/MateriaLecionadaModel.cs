using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSchool.Models
{
    public class MateriaLecionadaModel
    {
        public int idMateriaLecionada { get; set; }

        public int ano { get; set; }

        public int idMateria { get; set; }

        public virtual MateriaModel materia { get; set; }

        public int idProfessor { get; set; }
        public virtual ProfessorModel professor { get; set; }

        public int semestre { get; set; }
    }
}