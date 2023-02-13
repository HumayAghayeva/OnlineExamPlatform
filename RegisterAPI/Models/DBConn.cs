using Microsoft.EntityFrameworkCore;

namespace RegisterAPI.Models
{
    public class DBConn:DbContext
    {
        public DBConn(DbContextOptions<DBConn> options):base(options)
        {

        }
        DbSet<User> users { get; set; }
    }
}
