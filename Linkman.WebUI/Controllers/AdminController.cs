using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Linkman.Domain.Abstract;
using Linkman.Domain.Entities;

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

        public ViewResult Edit(int personId)
        {
            Person person = _repository.People.FirstOrDefault(p => p.PersonID == personId);

            return View(person);
        }

        public ViewResult Code()
        {
            IEnumerable<string> departmentList = Enum.GetNames(typeof(EDepartment));

            return View(departmentList);
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _repository.SavePerson(person);
                TempData["Message"] = string.Format("{0} has been saved", person.Name);
                return RedirectToAction("Index");
            }
            else
                return View(person);
        }

        public ViewResult Create()
        {
            return View("Edit", new Person());
        }
        public ActionResult Delete(int personId)
        {
            Person deletePerson = _repository.DeletePerson(personId);
            if (deletePerson != null)
            {
                TempData["Message"] = string.Format("Delete successfully");
            }
            return RedirectToAction("Index");
        }
    }
}