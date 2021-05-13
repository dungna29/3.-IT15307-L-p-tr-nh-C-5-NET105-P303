using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NET105_Tutorial_Csharp5_Dungna29.Models;
using NET105_Tutorial_Csharp5_Dungna29.Models.Convention;

namespace NET105_Tutorial_Csharp5_Dungna29.DBContextFpoly
{
    public class DBContextFPOLY:DbContext
    {
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            builder.AddConsole();
        });

        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Color> Colors { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Student1> Student1s { set; get; }
        public DbSet<Grade1> Grade1s { set; get; }
        public DbSet<Student2> Student2s { set; get; }
        public DbSet<Grade2> Grade2s { set; get; }
        public DbSet<Student3> Student3s { set; get; }
        public DbSet<Grade3> Grade3s { set; get; }  
        public DbSet<Student4> Student4s { set; get; }
        public DbSet<Grade4> Grade4s { set; get; }
        public DbSet<Student> Students { set; get; }
        public DbSet<StudentAddress> StudentAddress { set; get; }
        public DBContextFPOLY(DbContextOptions<DBContextFPOLY> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(loggerFactory); // thiết lập logging
        }


    }
}
