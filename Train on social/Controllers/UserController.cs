using BLL.service.implemention;
using DAL.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Train_on_social.Controllers
{
    public class UserController : Controller
    {
        public UserService  User =new UserService();
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult getallusers()
        {
           var result= User.GetAllUsers();

            return View(result);
        }
        [HttpGet]
        public IActionResult create()
        {
      
            return View();  

        }

        [HttpPost]
        public IActionResult create(user user)
        {

             
            if(ModelState.IsValid)
            {
                User.IsCreated(user);
                return RedirectToAction("getallusers");

            }
            return View();

        }
    }
}
