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
            Guid guid = Guid.NewGuid();
            Guid guid2 = Guid.NewGuid();
            //    modelBuilder.Entity<Post>(); // для добавления в БД данных колонки
            modelBuilder.Entity<DefectEntity>().HasData(new DefectEntity[]
                {
                    new DefectEntity {
                                Id = new Guid("11111111-9833-45ca-9017-1ded701ef149"),
                                Name = "name1",
                                CreatedAt = DateTime.Parse("2022-01-24T14:54:39.230Z"),

                                UpdateBy = new Guid("11111111-9833-45ca-9017-1ded701ef149"),
                                Image = "image1",
                                Description = "description1",
                                InventoryEntity = null
                            },
                    new DefectEntity {
                                Id = new Guid("22222222-9833-45ca-9017-1ded701ef149"),
                                Name = "name2",
                                CreatedAt = DateTime.Parse("2022-01-24T14:54:39.230Z"),

                                UpdateBy = new Guid("22222222-9833-45ca-9017-1ded701ef149"),
                                Image = "image2",
                                Description = "description2",
                                InventoryEntity = null
                            },
                });
            modelBuilder.Entity<RoomEntity>().HasData(new RoomEntity[]
            {
                new RoomEntity {
                    Id = guid2,
                    Name =  "Name2",
                    CreatedAt = DateTime.Parse("2021-01-24T14:54:39.230Z"),
                    DepartmentEntityId = guid,
                }
            }); ;
            modelBuilder.Entity<DepartmentEntity>().HasData(new DepartmentEntity[]
            {
                new DepartmentEntity {
                    Id = guid,
                    CreatedAt = DateTime.Parse("2021-01-24T14:54:39.230Z"),
                    Name = "DepName",
                    UpdateBy = Guid.NewGuid(),
                    RoomsEntityList = new List<RoomEntity>()
                    
                }
            });
            //    modelBuilder.Entity<Criminal>().Ignore(c => c.ammount); //для игнорирования свойства
            //    modelBuilder.Entity<User>().Property(b => b.Name).IsRequired();
            //    modelBuilder.Entity<Comment>().HasData(
            //        new Comment { Title = "Common comment", AuthorId = 33});
            //    modelBuilder.Entity<Comment>();
        }
    }
}
