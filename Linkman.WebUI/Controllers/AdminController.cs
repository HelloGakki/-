using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Linkman.Domain.Abstract;

namespace Linkman.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IPeopleRepository _repository;

        public AdminController(IPeopleRepository repo)
        {
            _repository = repo;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View(_repository.People);
        }
    }
}