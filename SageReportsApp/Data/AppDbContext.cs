using Microsoft.EntityFrameworkCore;
using SageReportsApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageReportsApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<RelatedFirm> RelatedFirms { get; set; }
        public DbSet<SourceSystem> SourceSystems { get; set; }

        public AppDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string currentFolder = Directory.GetCurrentDirectory();
            Directory.CreateDirectory(Path.Combine(currentFolder, "Database"));
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(currentFolder, "Database"));
            optionsBuilder.UseSqlServer(@$"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=sage-reports-db;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|DbFile.mdf");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
