using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Log
    {
        [Key]
        public int LogId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime dtInclusao { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime dtAtualizacao { get; set; }

        [Required]
        [ForeignKey("AdminId")]
        public int UserId { get; set; }


    }
}
