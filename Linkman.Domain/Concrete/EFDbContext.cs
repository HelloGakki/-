using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Linkman.Domain.Entities;

namespace Linkman.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}
