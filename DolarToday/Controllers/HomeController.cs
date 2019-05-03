using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using DolarToday.Models;

namespace DolarToday.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string urlDolar = "https://api.cambio.today/v1/quotes/USD/ARS/json?quantity=1&key=1996|bXyeYQ8Ve*eK_GacjCfmfRtNYsq*vEnm";
            string urlEuro = "https://api.cambio.today/v1/quotes/EUR/ARS/json?quantity=1&key=1996|bXyeYQ8Ve*eK_GacjCfmfRtNYsq*vEnm";
            string urlReal = "https://api.cambio.today/v1/quotes/BRL/ARS/json?quantity=1&key=1996|bXyeYQ8Ve*eK_GacjCfmfRtNYsq*vEnm";
            HttpClient clientDolar = new HttpClient();
            HttpClient clientEuro = new HttpClient();
            HttpClient clientReal = new HttpClient();
            clientDolar.BaseAddress = new Uri(urlDolar);
            clientEuro.BaseAddress = new Uri(urlEuro);
            clientReal.BaseAddress = new Uri(urlReal);
            HttpResponseMessage responseDolar = clientDolar.GetAsync(urlDolar).Result;
            HttpResponseMessage responseEuro = clientEuro.GetAsync(urlEuro).Result;
            HttpResponseMessage responseReal = clientReal.GetAsync(urlReal).Result;
            var dataDolar = responseDolar.Content.ReadAsAsync<DolarTodayResult>().Result;
            var dataEuro = responseEuro.Content.ReadAsAsync<DolarTodayResult>().Result;
            var dataReal = responseReal.Content.ReadAsAsync<DolarTodayResult>().Result;
            ViewData["Dolar"] = dataDolar.result.value;
            ViewData["Euro"] = dataEuro.result.value;
            ViewData["Real"] = dataReal.result.value;
            this.HttpContext.Response.AddHeader("refresh", "5; url=" + Url.Action("Index"));
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}