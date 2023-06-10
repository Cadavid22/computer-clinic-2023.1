using computer.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace computerClinic.Backend.Date
{
    public class DataContext : DbContext
    { 
        public DataContext(DbContextOptions<DataContext>option) : base(option) 
        {
            
        }
        
        public DbSet<CenterComputer > MyComputers { get; set; }
            
        }
    }

