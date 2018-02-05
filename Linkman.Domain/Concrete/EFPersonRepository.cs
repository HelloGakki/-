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

        public Person DeletePerson(int personId)
        {
            Person deletePerson = _context.People.Find(personId);
            if (deletePerson != null)
            {
                _context.People.Remove(deletePerson);
                _context.SaveChanges();
            }
            return deletePerson;
        }

        public void SavePerson(Person person)
        {
            if (person.PersonID == 0)
                _context.People.Add(person);
            else
            {
                Person dbEntry = _context.People.Find(person.PersonID);
                if (dbEntry != null)
                {
                    dbEntry.Name = person.Name;
                    dbEntry.Age = person.Age;
                    dbEntry.Department = person.Department;
                    dbEntry.Email = person.Email;
                    dbEntry.Gender = person.Gender;
                    dbEntry.Mobile = person.Mobile;
                    dbEntry.Tel = person.Tel;
                    dbEntry.TelExt = person.TelExt;
                }
            }
            _context.SaveChanges();
        }
    }
}
