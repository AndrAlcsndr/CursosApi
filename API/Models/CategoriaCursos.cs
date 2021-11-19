using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CategoriaCursos
    {
        [Key]
        public int CategoriaId { get; set; }

        [Column (TypeName="nvarchar(50)")]
        [StringLength(50, MinimumLength = 5)]
        public string Label { get; set; }
    }
}
