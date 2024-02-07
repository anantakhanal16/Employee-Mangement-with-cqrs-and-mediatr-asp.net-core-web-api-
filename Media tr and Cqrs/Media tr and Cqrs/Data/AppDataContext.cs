using Media_tr_and_Cqrs.Model;
using Microsoft.EntityFrameworkCore;

namespace Media_tr_and_Cqrs.Data
{
    public class AppDataContext:DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }

}
