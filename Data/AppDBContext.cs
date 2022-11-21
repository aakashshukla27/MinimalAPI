using DotNet6MinApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet6MinAPI.Data{
    public class AppDBContext : DbContext{
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){

        }
        
        public DbSet<Command> Commands => Set<Command>();

        
    }
}