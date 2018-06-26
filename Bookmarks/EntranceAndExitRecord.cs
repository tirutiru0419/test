using EntranceAndExitRecord.Entity;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace EntranceAndExitRecord.Model
{
    public class EntranceAndExitRecordModel : DbContext
    {
        public DbSet<Item> Items { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = new SqliteConnectionStringBuilder { DataSource = @"C:\work\EntranceAndExitRecord.db" }.ToString();
            optionsBuilder.UseSqlite(new SqliteConnection(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 複合キーの場合、以下のように指定してやる。
            // ない場合「Entity type 'Item' has composite primary key defined with data annotations. To set composite primary key, use fluent API.」と表示される
            modelBuilder.Entity<Item>().HasKey(c => new { c.Id, c.PointNo });
        }
    }

    public class Book
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }

}