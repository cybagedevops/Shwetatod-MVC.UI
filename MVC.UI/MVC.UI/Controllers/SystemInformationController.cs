using System.Collections.Generic;
using System.Web.Mvc;

using System.Net.Http;
using WebAPIHandson.Models;

namespace MVC.UI.Controllers
{
    public class SystemInformationController : Controller
    {
        // GET: SystemInformation         // GET: Home
        public ActionResult Index()
        {
            //IEnumerable<SystemInformation> emptList; HttpResponseMessage response = Globalvariables.WebCilent.GetAsync("SystemInformation").Result;
        
           //emptList = response.Content.ReadAsAsync<IEnumerable<SystemInformation>>().Result; return View(emptList);
            IEnumerable<SystemInformation> emptList; HttpResponseMessage response = Globalvariables.WebCilent.GetAsync("SystemInformation").Result;
            emptList = response.Content.ReadAsAsync<IEnumerable<SystemInformation>>().Result; 
            return View(emptList);
        }
    }


    }
