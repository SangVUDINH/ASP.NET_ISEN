using System.Diagnostics.CodeAnalysis;
using Isen.Dotnet.Library.Model;
using Microsoft.EntityFrameworkCore;

namespace Isen.Dotnet.Library.Context
{    
    public class ApplicationDbContext : DbContext
    {        
        // Listes des classes modèle / tables
        // public DbSet<Person> PersonCollection { get; set; }
        public DbSet<City> CityCollection { get; set; }

        // public DbSet<Role> RoleCollection { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonRole> PersonRoles { get; set; }

        public DbSet<Service> ServiceCollection { get; set; }
        
        public ApplicationDbContext(
            [NotNullAttribute] DbContextOptions options) : 
            base(options) {  }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

            // Tables et relations
            modelBuilder
                // Associer la classe Person...
                .Entity<Person>()
                // ... à la table Person
                .ToTable(nameof(Person))
                // Description de la relation Person.BirthCity
                .HasOne(p => p.BirthCity)
                // Relation réciproque (omise)
                .WithMany()
                // Clé étrangère qui porte cette relation
                .HasForeignKey(p => p.BirthCityId);
            // Pareil pour ResidenceCity
            modelBuilder.Entity<Person>()
                .HasOne(p => p.ResidenceCity)
                .WithMany()
                .HasForeignKey(p => p.ResidenceCityId);
            // Et utiliser le champ Id comme clé primaire
            // Déclaration optionnelle, car le nommage
            // Id ou PersonId est reconnu comme convention
            // pour les clés primaires ou étrangères
            modelBuilder.Entity<Person>()
                .HasKey(p => p.Id);

            // modelBuilder
            //     .Entity<Person>()
            //     .HasMany<Role>(p => p.Roles)
            //     .WithMany(r => r.Persons);

            modelBuilder
                .Entity<Person>()
                .ToTable(nameof(Person))
                .HasOne(p => p.ServicePerson)
                .WithMany()
                .HasForeignKey(p => p.ServicePersonId);

                //Table de liason pour le many-many entre Person et Role
            modelBuilder.Entity<PersonRole>()
                .ToTable(nameof(PersonRole))
                .HasKey(pr => new { pr.PersonId, pr.RoleId });
             modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.Person)
                .WithMany(p => p.PersonRoles)
                .HasForeignKey(pr => pr.PersonId);  
            modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.Role)
                .WithMany(r => r.PersonRoles)
                .HasForeignKey(pr => pr.RoleId);

            // Pareil pour City
            modelBuilder
                .Entity<City>()
                .ToTable(nameof(City))
                .HasKey(c => c.Id);
            
            // Role
            modelBuilder
                .Entity<Role>()
                .ToTable(nameof(Role))
                .HasKey(c => c.Id);

                // Service
            modelBuilder
                .Entity<Service>()
                .ToTable(nameof(Service))
                .HasKey(c => c.Id);

        }

    }
}