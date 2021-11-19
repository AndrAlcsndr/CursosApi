using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        [StringLength(300, MinimumLength = 5)]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime _Data_ini { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime _Data_fin { get; set; }
        [Column (TypeName ="Integer")]
        public int Quantidade { get; set; }

        [ForeignKey("CategoriaId")]
        public int Categorias { get; set; }
    }
}
