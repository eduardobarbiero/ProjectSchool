using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectSchool.Models
{
    public class MateriaLecionadaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idMateriaLecionada { get; set; }

        public int ano { get; set; }

        public int idMateria { get; set; }

        public virtual MateriaModel materia { get; set; }

        public int idProfessor { get; set; }
        public virtual ProfessorModel professor { get; set; }

        public int semestre { get; set; }
    }
}