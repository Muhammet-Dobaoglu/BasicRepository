using BasicRepository.Data;
using Microsoft.EntityFrameworkCore;

namespace BasicRepository.context
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> db) : base(db)

        {

        }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
    }
}
