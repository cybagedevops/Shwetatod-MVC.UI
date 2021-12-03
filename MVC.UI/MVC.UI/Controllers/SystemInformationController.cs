using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using System.Net.Http.Headers;
using System.Web.Configuration;
using WebAPIHandson.Models;

namespace WebMvcSystemInfo.Controllers
{
    public class SystemInformationController : Controller
    {

        public HttpClient WebCilent = new HttpClient();
        // GET: SystemInformation



        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<SystemInformation> emptList;




            string apiUrl = WebConfigurationManager.AppSettings["ApiUrl"];



            WebCilent.BaseAddress = new Uri(apiUrl);



            WebCilent.DefaultRequestHeaders.Clear();



            WebCilent.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            HttpResponseMessage response = WebCilent.GetAsync("SystemInformation").Result;
            emptList = response.Content.ReadAsAsync<IEnumerable<SystemInformation>>().Result;



            return View(emptList);
        }




    }
}