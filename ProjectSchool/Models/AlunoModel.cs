﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectSchool.Models
{
    public class AlunoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAluno { get; set; }

        [Required] 
        [Display(Name = "Nome do Aluno:")]
        public string nomeAluno {get; set; }
    }
}