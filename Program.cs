using BookStore.Infrastructureprotected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("Server=.\\SqlExpress;Database=AcademyDbNthier402;Trusted_Connection=True;TrustServerCertificate=True");
};

namespace BookStoreManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
        }
    }
}
