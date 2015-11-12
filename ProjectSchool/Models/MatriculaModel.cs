using ProjectSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectSchool.Models
{
    public class MatriculaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAluno { get; set; }

        public virtual AlunoModel aluno { get; set; }

        public int idMateriaLecionada { get; set; }

        public virtual MateriaLecionadaModel materiaLecionada { get; set; }

        public int idMatricula { get; set; }

        public double nota { get; set; }

    }
}