using Microsoft.EntityFrameworkCore;

namespace project_third_efcoreApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }

}