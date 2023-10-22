using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationsQuantityApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=empl_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Employee>().ToTable("EmployeesFull");
            //modelBuilder.Entity<EmployeeProfile>().ToTable("EmployeesFull");

            //modelBuilder.Entity<Employee>()
            //            .HasOne(e => e.Profile)
            //            .WithOne(p => p.Employee)
            //            .HasForeignKey<EmployeeProfile>(p => p.EmployeeId);

            modelBuilder.Entity<EmployeeProfile>()
                        .HasOne(p => p.Employee)
                        .WithOne(e => e.Profile)
                        .HasForeignKey<Employee>(e => e.ProfileId);

            modelBuilder.Entity<Employee>()
                        .HasOne(e => e.Company)
                        .WithMany(c => c.Employees)
                        .HasForeignKey(e => e.CompanyId)
                        .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Employee>()
            //            .HasMany(e => e.Projects)
            //            .WithMany(p => p.Employees)
            //            .UsingEntity(ep => ep.ToTable("EmployeeProject"));


            modelBuilder
                .Entity<Project>()
                .HasMany(p => p.Employees)
                .WithMany(e => e.Projects)
                .UsingEntity<DateMark>(
                    key => key
                            .HasOne(dm => dm.Employee)
                            .WithMany(empl => empl.DateMarks)
                            .HasForeignKey(dm => dm.EmployeeId),
                    key => key
                            .HasOne(dm => dm.Project)
                            .WithMany(pr => pr.DateMarks)
                            .HasForeignKey(dm => dm.ProjectId),
                    dm =>
                    {
                        dm.Property(dm => dm.Mark)
                          .HasDefaultValue(DateTime.Now);
                        dm.HasKey(dm => new { dm.ProjectId, dm.EmployeeId });
                        dm.ToTable("EmployeeProjectMark");
                    }
                );
                        


            


        }
    }
}
