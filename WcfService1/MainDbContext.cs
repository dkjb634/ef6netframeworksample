using System;
using System.Data.Entity;

namespace WcfService1
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(): base("mssql")
        {
            
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Post2> Posts2 { get; set; }
        
    }
    
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Content { get; set; }
        public DateTime? Date { get; set; }
    }
    
    public class Post2
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Content { get; set; }
        public DateTime? Date { get; set; }
    }
}