using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linkman.Domain.Abstract;
using Linkman.Domain.Entities;

namespace Linkman.Domain.Concrete
{
    public class EFPersonRepository : IPeopleRepository
    {
        private EFDbContext _context = new EFDbContext();

        public IEnumerable<Person> People
        {
            get
            {
                return _context.People;
            }
        }
    }
}
