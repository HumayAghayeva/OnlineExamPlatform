using Microsoft.EntityFrameworkCore;

namespace OnlineExamAPI.Models
{
    public class DBConn:DbContext
    {
        public DBConn(DbContextOptions<DBConn> options):base(options)
        {

        }
        DbSet<User> users { get; set; }
    }
}
