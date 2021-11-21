using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } //Set = Conjunto. Por eso recomienda Categories, porque las tablas (categories), representa un conjunto
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ControlEmployees> ControlEmployees { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectControl> ProjectControls { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<User>().ToTable("User");
            builder.Entity<Client>().ToTable("Clients").HasBaseType<User>();
            builder.Entity<Contractor>().ToTable("Contractors").HasBaseType<User>();
            builder.Entity<City>().ToTable("Cities");
            builder.Entity<Project>().ToTable("Projects");
            builder.Entity<Posts>().ToTable("Posts");
            builder.Entity<Employees>().ToTable("Employees");
            builder.Entity<Job>().ToTable("Jobs");
            builder.Entity<ProjectControl>().ToTable("ProjectControls");
            builder.Entity<ControlEmployees>().ToTable("ControlEmployees");
            builder.Entity<ControlEmployees>().HasKey(p => p.ControlEmployeesId);
            
            builder.Entity<User>().HasKey(p => p.Cuser);
            builder.Entity<User>().Property(p => p.Cuser).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(p => p.Cpassword).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.Temail).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.Cdni).IsRequired().HasMaxLength(8);
            builder.Entity<User>().Property(p => p.Nname).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.Nlastname).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.isadmin).IsRequired();

            builder.Entity<Client>().Property(p => p.Tbio).IsRequired().HasMaxLength(50);
            builder.Entity<Client>().Property(p => p.Taddress).IsRequired().HasMaxLength(50);
            builder.Entity<Client>().Property(p => p.Nlastname);
            

            builder.Entity<City>().HasKey(p => p.Ccity);
            builder.Entity<City>().Property(p => p.Ncity).IsRequired().HasMaxLength(30);

            builder.Entity<Contractor>().Property(p => p.Tbio);
            builder.Entity<Contractor>().Property(p => p.Neducation).HasMaxLength(50);
            builder.Entity<Contractor>().Property(p => p.Numphone).HasMaxLength(50);

            builder.Entity<Project>().HasKey(p => p.Cproject);
            builder.Entity<Project>().Property(p => p.Nproject);
            builder.Entity<Project>().Property(p => p.Created_at);
            builder.Entity<Project>().Property(p => p.Tdescription);
            builder.Entity<Project>().Property(p => p.Fstatus);
            builder.Entity<Project>().Property(p => p.Mbudget);
            builder.Entity<Project>()
                .HasOne(p => p.Contractor_Cuser)
                .WithMany(q => q.CProject)
                .HasForeignKey(id => id.ContractorId);
            

            builder.Entity<Posts>().HasKey(p => p.Cposts);
            builder.Entity<Posts>().Property(p => p.Ntitle);
            builder.Entity<Posts>().Property(p => p.Tbody);
            builder.Entity<Posts>().Property(p => p.Created_at);
            builder.Entity<Posts>().Property(p => p.Mbudget);
            builder.Entity<Posts>().Property(p => p.Views);
            builder.Entity<Posts>().Property(p => p.Pic);
            
            builder.Entity<Employees>().HasKey(p => p.Cemployee);
            builder.Entity<Employees>().Property(p => p.Nemployee);
            builder.Entity<Employees>().Property(p => p.Tposition);
            builder.Entity<Employees>().Property(p => p.Mpayment);
            builder.Entity<Employees>().Property(p => p.Tworks);

            builder.Entity<Employees>()
                .HasOne(p => p.Cjob)
                .WithOne(q => q.CEmployee)
                .HasForeignKey<Job>(id => id.Cjob);

            builder.Entity<Employees>()
                .HasMany(p => p.CControlEmployees)
                .WithOne(q => q.Employees_Cemployee)
                .HasForeignKey(id => id.EmployeeId);

            builder.Entity<Job>().HasKey(p=>p.Cjob);
            builder.Entity<Job>().Property(p => p.Njob);
            builder.Entity<Job>().Property(p => p.Tdescription);
            
            builder.Entity<ProjectControl>().HasKey(p => p.Ccontrol);
            builder.Entity<ProjectControl>().Property(p => p.Nproject);
            builder.Entity<ProjectControl>().Property(p => p.Fstatus);
            builder.Entity<ProjectControl>().Property(p => p.Dlastedited);
            builder.Entity<ProjectControl>().Property(p => p.Ttasks);
            builder.Entity<ProjectControl>().Property(p => p.Qemployees);
            builder.Entity<ProjectControl>().Property(p => p.Mbudget);
            builder.Entity<ProjectControl>().Property(p => p.Qprogress);

            builder.Entity<ProjectControl>()
                .HasOne(p => p.CProject)
                .WithOne(p => p.CProjectControl)
                .HasForeignKey<Project>(id => id.Cproject);

            builder.Entity<ProjectControl>()
                .HasMany(p => p.CControlEmployees)
                .WithOne(q => q.ProjectControl_Control)
                .HasForeignKey(id => id.ProjectControlId);

        }
    }
}
