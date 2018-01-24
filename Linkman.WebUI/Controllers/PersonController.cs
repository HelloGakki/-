using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Linkman.Domain.Abstract;
using Linkman.Domain.Entities;
using Linkman.WebUI.Models;

namespace Linkman.WebUI.Controllers
{
    public class PersonController : Controller
    {
        private IPeopleRepository _repository;
        public int PageSize = 4;

        public PersonController(IPeopleRepository peopleRepository)
        {
            this._repository = peopleRepository;
        }

        public ViewResult List(int page = 1)
        {
            PersonListViewModel model = new PersonListViewModel();
            model.People = _repository.People.OrderBy(p => p.PersonID).Skip((page - 1) * PageSize).Take(PageSize);
            model.PagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalItem = _repository.People.Count()
            };
            return View(model);
        }
    }
}