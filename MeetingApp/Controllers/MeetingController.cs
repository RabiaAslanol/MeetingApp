using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {   
            if(ModelState.IsValid){
                Respository.CreateUsers(model);
                ViewBag.UserCount=Respository.Users.Where(info=>info.WillAttend==true).Count();
                return View("thanks", model);  
            }else{
                return View(model);
            }
            
        }
        [HttpGet]
         public IActionResult List()
        {
            return View(Respository.Users);
        }
        //meeting/details/1
        public IActionResult Details(int id){
            return View(Respository.GetById(id));
        }
    }
}