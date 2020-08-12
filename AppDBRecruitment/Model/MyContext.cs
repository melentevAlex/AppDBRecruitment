using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDBRecruitment.Model
{
    public class MyContext : DbContext // связывает модель с БД
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<UserDetailes> UsersDetailes { get; set; }
        public DbSet<Vacansia> Vacansias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1RK0ITO\\SQLEXPRESS;Database=RecruitmentDB;Trusted_Connection=True");
        }

        public MyContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
