using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Linkman.Domain.Abstract;
using Linkman.Domain.Entities;

namespace Linkman.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IPeopleRepository _repository;

        public NavController(IPeopleRepository repo)
        {
            this._repository = repo;
        }

        // GET: Nav
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<EDepartment> categories = _repository.People
                .Select(x => x.Department)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}