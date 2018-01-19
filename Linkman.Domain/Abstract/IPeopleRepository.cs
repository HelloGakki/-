using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linkman.Domain.Entities;

namespace Linkman.Domain.Abstract
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> People { get; }
    }
}
