using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{

    public class HomeController: Controller
    {
        //localhost
        public IActionResult Index(){
            int saat=DateTime.Now.Hour;
            //ViewBag.Selamlama = saat > 12 ? "İyi Günler":"Günaydın";
            ViewData["Selamlama"]=saat > 12 ? "İyi Günler":"Günaydın";
            int UserCount=Respository.Users.Where(info=> info.WillAttend==true).Count();


            var meetinginfo= new MeetingInfo()
            {
                Id=1,
                Location="İstanbul, Abc Kongre Merkezi",
                Date=new DateTime(2024, 01,20,20,0,0),
                NumberOfPeople=UserCount
            };
            return View(meetinginfo);
        }    
    }
}