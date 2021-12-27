

using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogToTag> BlogToTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<GetEstimate> GetEstimates { get; set; }
        public DbSet<LatestPost> LatestPosts { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Popular> Populars { get; set; }
        public DbSet<QuestionAccordion> QuestionAccordions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

        
    
 
