using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AndrewPechaWebApp.Models
{
    public class TestSQLite
    {
        public int ID { get; set; }
        public int number { get; set; }
        public string word { get; set; }
    }

    public class TESTSQLiteContext : DbContext
    {
        public DbSet<TestSQLite> TestStuff { get; set; }

        public TESTSQLiteContext()
        : base("TESTSQLiteContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<TESTSQLiteContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

    }
}