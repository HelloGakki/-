using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Linkman.Domain.Abstract;
using Linkman.Domain.Entities;

namespace Linkman.WebUI.Controllers
{
    public class PersonController : Controller
    {
        private IPeopleRepository _repository;

        public PersonController(IPeopleRepository peopleRepository)
        {
            this._repository = peopleRepository;
        }

        public ViewResult List()
        {
            return View(_repository.People);
        }
    }
}