using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CursosCastContext : DbContext
    {
        public CursosCastContext(DbContextOptions<CursosCastContext> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CategoriaCursos> Categorias { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
