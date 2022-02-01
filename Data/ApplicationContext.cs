using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{

    public class ApplicationContext : DbContext
    {
        public DbSet<RoomEntity>? Rooms { get; set; }
        public DbSet<InventoryEntity>? InventoryLots { get; set; }
        public DbSet<UserEntity>? Users { get; set; }
        public DbSet<InventorySetupEntity>? Setups { get; set; }
        public DbSet<DepartmentEntity>? Departments { get; set; }
        public DbSet<DefectEntity>? Defects { get; set; }

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=inventoryWithArchDB;Trusted_Connection=True;");*/
            /*optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=inventoryWithArchDB;Trusted_Connection=True;",
             *b => b.MigrationsAssembly("Data"));*/
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    base.OnModelCreating(modelBuilder);
            //    modelBuilder.Entity<Post>(); // для добавления в БД данных колонки
            //    modelBuilder.Entity<Post>().HasData(new Post[]
            //    {
            //        new Post { Title = "Jenny", Description = "Jenny1", AuthorId = 33},
            //        new Post { Title = "Kenny", Description = "Jenny2", AuthorId = 44},
            //        new Post { Title = "Tony", Description = "Jenny3", AuthorId = 55}
            //    });
            //    modelBuilder.Entity<Criminal>().Ignore(c => c.ammount); //для игнорирования свойства
            //    modelBuilder.Entity<User>().Property(b => b.Name).IsRequired();
            //    modelBuilder.Entity<Comment>().HasData(
            //        new Comment { Title = "Common comment", AuthorId = 33});
            //    modelBuilder.Entity<Comment>();
        }
    }
}
