using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDB _db;

        public UserController(UserDB db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            UserVM userVM = new UserVM();

            

            userVM.Users = _db.Users.ToList();


            return View(userVM);
        }

        public IActionResult Create()
        {



            return View();
        }

        [HttpPost]
        public IActionResult Create(UserVM userVM)
        {
            _db.Users.Add(userVM.User);
            _db.SaveChanges();

            return RedirectToAction("List");
        }





    }
}
