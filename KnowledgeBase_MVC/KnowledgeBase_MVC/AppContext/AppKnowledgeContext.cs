using KnowledgeBase_MVC.Models;
using Microsoft.EntityFrameworkCore;


namespace KnowledgeBase_MVC.AppContext
{
    public class AppKnowledgeContext : DbContext
    {
        public AppKnowledgeContext(DbContextOptions<AppKnowledgeContext> options) : base(options) { }

        public DbSet<Company> Company { get; set; }

        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Service> Service { get; set; }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<ConnectionCompanyProduct> ConnectionCompanyProduct { get; set; }
        public DbSet<ConnectionCompanyService> ConnectionCompanyService { get; set; }



    }
}
