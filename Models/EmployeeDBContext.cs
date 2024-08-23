using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext()
        {
        }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {

        //        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //        //                optionsBuilder.UseSqlServer("Server=DESKTOP-CL273J0;Database=OMSDbBackup;User ID= sa; Password=Bitapps@123;Trusted_Connection=False;MultipleActiveResultSets=True");
        //        IConfigurationRoot configuration = new ConfigurationBuilder()
        //                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //                    .AddJsonFile("appsettings.json")
        //                    .Build();
        //        optionsBuilder.UseSqlServer(configuration.GetConnectionString("CoreDatabase"));
        //    }
        //}

    }
}
