using APITask.Models;
using Microsoft.EntityFrameworkCore;

namespace APITask.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Station> Stations { get; set; }
        public DbSet<Line> Lines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Line>().HasData(
                new Line { Id = 1, Name = "Line 1" },
                new Line { Id = 2, Name = "Line 2" }
            );
            modelBuilder.Entity<Station>().HasData(
        new Station { Id = 1, Name = "Helwan", isTransitional = false, Position = 1, LineId = 1 },
    new Station { Id = 2, Name = "Ain Helwan", isTransitional = false, Position = 2, LineId = 1 },
    new Station { Id = 3, Name = "Helwan University", isTransitional = false, Position = 3, LineId = 1 },
    new Station { Id = 4, Name = "Wadi Hof", isTransitional = false, Position = 4, LineId = 1 },
    new Station { Id = 5, Name = "Hadayek Helwan", isTransitional = false, Position = 5, LineId = 1 },
    new Station { Id = 6, Name = "El-Maasara", isTransitional = false, Position = 6, LineId = 1 },
    new Station { Id = 7, Name = "Tora El-Balad", isTransitional = false, Position = 7, LineId = 1 },
    new Station { Id = 8, Name = "Kozzika", isTransitional = false, Position = 8, LineId = 1 },
    new Station { Id = 9, Name = "Tora El-Asmant", isTransitional = false, Position = 9, LineId = 1 },
    new Station { Id = 10, Name = "Sakanat El-Maadi", isTransitional = false, Position = 10, LineId = 1 },
    new Station { Id = 11, Name = "Maadi", isTransitional = false, Position = 11, LineId = 1 },
    new Station { Id = 12, Name = "Hadayek El-Maadi", isTransitional = false, Position = 12, LineId = 1 },
    new Station { Id = 13, Name = "Dar El-Salam", isTransitional = false, Position = 13, LineId = 1 },
    new Station { Id = 14, Name = "El-Zahraa", isTransitional = false, Position = 14, LineId = 1 },
    new Station { Id = 15, Name = "Mar Girgis", isTransitional = false, Position = 15, LineId = 1 },
    new Station { Id = 16, Name = "El-Malek El-Saleh", isTransitional = false, Position = 16, LineId = 1 },
    new Station { Id = 17, Name = "Al-Sayeda Zeinab", isTransitional = false, Position = 17, LineId = 1 },
    new Station { Id = 18, Name = "Saad Zaghloul", isTransitional = false, Position = 18, LineId = 1 },
    new Station { Id = 19, Name = "Sadat", isTransitional = true, Position = 19, LineId = 1, TransitionalStationId = 45 },
    new Station { Id = 20, Name = "Nasser", isTransitional = false, Position = 20, LineId = 1 },
    new Station { Id = 21, Name = "Orabi", isTransitional = false, Position = 21, LineId = 1 },
    new Station { Id = 22, Name = "Al-Shohadaa", isTransitional = true, Position = 22, LineId = 1, TransitionalStationId = 43 },
    new Station { Id = 23, Name = "Ghamra", isTransitional = false, Position = 23, LineId = 1 },
    new Station { Id = 24, Name = "El-Demerdash", isTransitional = false, Position = 24, LineId = 1 },
    new Station { Id = 25, Name = "Manshiet El-Sadr", isTransitional = false, Position = 25, LineId = 1 },
    new Station { Id = 26, Name = "Kobri El-Qobba", isTransitional = false, Position = 26, LineId = 1 },
    new Station { Id = 27, Name = "Hammamat El-Qobba", isTransitional = false, Position = 27, LineId = 1 },
    new Station { Id = 28, Name = "Saray El-Qobba", isTransitional = false, Position = 28, LineId = 1 },
    new Station { Id = 29, Name = "Hadayeq El-Zaitoun", isTransitional = false, Position = 29, LineId = 1 },
    new Station { Id = 30, Name = "Helmeyet El-Zaitoun", isTransitional = false, Position = 30, LineId = 1 },
    new Station { Id = 31, Name = "El-Matareyya", isTransitional = false, Position = 31, LineId = 1 },
    new Station { Id = 32, Name = "Ain Shams", isTransitional = false, Position = 32, LineId = 1 },
    new Station { Id = 33, Name = "Ezbet El-Nakhl", isTransitional = false, Position = 33, LineId = 1 },
    new Station { Id = 34, Name = "El-Marg", isTransitional = false, Position = 34, LineId = 1 },
    new Station { Id = 35, Name = "El-Marg El-Gedida", isTransitional = false, Position = 35, LineId = 1 }
);

            modelBuilder.Entity<Station>().HasData(
            new Station { Id = 36, Name = "Shubra El-Kheima", isTransitional = false, Position = 1, LineId = 2 },
            new Station { Id = 37, Name = "Kolleyet El-Zeraa", isTransitional = false, Position = 2, LineId = 2 },
            new Station { Id = 38, Name = "El-Mazalat", isTransitional = false, Position = 3, LineId = 2 },
            new Station { Id = 39, Name = "El-Khalafawi", isTransitional = false, Position = 4, LineId = 2 },
            new Station { Id = 40, Name = "St. Teresa", isTransitional = false, Position = 5, LineId = 2 },
            new Station { Id = 41, Name = "Rod El-Farag", isTransitional = false, Position = 6, LineId = 2 },
            new Station { Id = 42, Name = "Masarra", isTransitional = false, Position = 7, LineId = 2 },
            new Station { Id = 43, Name = "Al-Shohadaa", isTransitional = true, Position = 8, LineId = 2, TransitionalStationId = 22 },
            new Station { Id = 44, Name = "Attaba", isTransitional = false, Position = 9, LineId = 2 },
            new Station { Id = 45, Name = "Sadat", isTransitional = true, Position = 10, LineId = 2, TransitionalStationId = 19 },
            new Station { Id = 46, Name = "Opera", isTransitional = false, Position = 11, LineId = 2 },
            new Station { Id = 47, Name = "Dokki", isTransitional = false, Position = 12, LineId = 2 },
            new Station { Id = 48, Name = "Cairo University", isTransitional = false, Position = 13, LineId = 2 },
            new Station { Id = 49, Name = "Faisal", isTransitional = false, Position = 14, LineId = 2 },
            new Station { Id = 50, Name = "Giza", isTransitional = false, Position = 15, LineId = 2 },
            new Station { Id = 51, Name = "Omm El-Masryeen", isTransitional = false, Position = 16, LineId = 2 },
            new Station { Id = 52, Name = "Sakiat Mekki", isTransitional = false, Position = 17, LineId = 2 },
            new Station { Id = 53, Name = "El-Mounib", isTransitional = false, Position = 18, LineId = 2 }
        );



        }
    } 
    }
