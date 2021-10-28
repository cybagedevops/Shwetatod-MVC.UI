using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http.Headers;

using System.Net.Http;
namespace MVC.UI
{
    public static class Globalvariables
    {
        public static HttpClient WebCilent = new HttpClient();

        static Globalvariables()
        {

            WebCilent.BaseAddress = new Uri("https://localhost:44337/api/");

            WebCilent.DefaultRequestHeaders.Clear();

            WebCilent.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}