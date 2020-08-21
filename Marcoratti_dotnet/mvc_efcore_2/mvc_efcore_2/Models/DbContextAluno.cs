using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_efcore_2.Models
{
    public class DbContextAluno : DbContext
    {
        public DbContextAluno(DbContextOptions<DbContextAluno> options) : base(options)
        { }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<TipoSocio> TipoSocios { get; set; }


    }
}
