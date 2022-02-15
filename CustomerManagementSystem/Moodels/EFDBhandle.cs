using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem.Moodels
{
    public class EFDBhandle : DbContext
    {

        public string conn = "Server=DESKTOP-QU4L7PJ\\SQLEXPRESS;Database=CustomerDetails_DB;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsB)
        {
            optionsB.UseSqlServer(conn);
        }
        public DbSet<Customer> Customers { get; set; }

    }
}
