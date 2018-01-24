using Linkman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Linkman.WebUI.Models
{
    public class PersonListViewModel
    {
        public IEnumerable<Person> People { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}