using Data.UnitOfWork.MockData;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{

    public class ApplicationContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Setup> Setups { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Defect> Defects { get; set; }

        /*public static async Task<SqlConnection> GetConnecton(string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlCommand cmd = sqlConnection.CreateCommand();
            SqlDataReader rdr = cmd.ExecuteReader();
            return sqlConnection; 
        }*/
        public ApplicationContext(DbContextOptions<ApplicationContext> opt) : base(opt)
        {

        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            *//*optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=inventoryWithArchDB;Trusted_Connection=True;");*/
            /*optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=inventoryWithArchDB;Trusted_Connection=True;",
             *b => b.MigrationsAssembly("Data"));*//*
        }*/


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid DepId = Guid.NewGuid();
            Guid MainAdmin = Guid.NewGuid();

            modelBuilder.Entity<Inventory>()
                .HasOne(inv => inv.Setup)
                .WithMany(setup => setup.InventoryList)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Inventory>()
                .HasOne(inv => inv.User)
                .WithMany(inv => inv.InventoryList)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Inventory>()
                .HasOne(inv => inv.Room)
                .WithMany(r => r.InventoryList)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Defect>()
                .HasOne(def => def.Inventory)
                .WithMany(inv => inv.DefectList)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Setup>()
                 .HasOne(setup => setup.Room)
                 .WithMany(r => r.SetupList)
                 .OnDelete(DeleteBehavior.SetNull);

            /*modelBuilder.Entity<Setup>()
                .HasOne(s => s.User)
                .WithOne(u => u.Setup)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<User>()
                .HasOne(u => u.Setup)
                .WithOne(s => s.User)
                .OnDelete(DeleteBehavior.SetNull);*/

            modelBuilder.Entity<Setup>()
                .HasMany(s => s.InventoryList)
                .WithOne(inv => inv.Setup)
                .OnDelete(DeleteBehavior.SetNull);

            /*var depMockData = new DepartmentMock().GetDepMock(DepId, MainAdmin);
            modelBuilder.Entity<Department>().HasData(depMockData);

            var userMockData = new UserMock().GetRandomData(10, MainAdmin);
            modelBuilder.Entity<User>().HasData(userMockData);

            string[] RoomNames = { "Ruby", "Node", ".Net" };
            var roomMockData = new RoomMock().GetRandomData(RoomNames, DepId);
            modelBuilder.Entity<Room>().HasData(roomMockData);

            var setupMockData = new SetupMock().GetRandomData(roomMockData, userMockData, MainAdmin);
            modelBuilder.Entity<Setup>().HasData(setupMockData);

            var inventoryMockData = new InventoryMock().GetRandomData(roomMockData, userMockData, setupMockData, MainAdmin);
            modelBuilder.Entity<Inventory>().HasData(inventoryMockData);

            var defectMockData = new DefectMock().GetRandomData(inventoryMockData, userMockData, MainAdmin);
            modelBuilder.Entity<Defect>().HasData(defectMockData);*/



            //    modelBuilder.Entity<Criminal>().Ignore(c => c.ammount); //для игнорирования свойства
            //    modelBuilder.Entity<User>().Property(b => b.Name).IsRequired();
            //    modelBuilder.Entity<Comment>().HasData(
            //        new Comment { Title = "Common comment", AuthorId = 33});
            //    modelBuilder.Entity<Comment>();
        }
    }
}
