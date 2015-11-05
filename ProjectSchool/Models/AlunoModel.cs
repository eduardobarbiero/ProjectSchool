using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectSchool.Models
{
    public class AlunoModel
    {
        public int idAluno { get; set; }

        [Required]
        [Display(Name = "Aluno:")]
        public string nomeAluno {get; set; }
    }
}