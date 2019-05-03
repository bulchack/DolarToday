using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DolarToday.Models;
using Newtonsoft.Json;

namespace DolarToday.Controllers
{
    public class DolarApiController : ApiController
    {
        // GET: api/DolarApi
        public IHttpActionResult Get()
        {
            //string url = "https://api.cambio.today/v1/quotes/USD/ARS/json?quantity=1&key=1996|bXyeYQ8Ve*eK_GacjCfmfRtNYsq*vEnm";
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(url);
            //HttpResponseMessage response = client.GetAsync(url).Result;
            //if(response.IsSuccessStatusCode)
            //{
            //    var data = response.Content.ReadAsAsync<DolarTodayResult>().Result;
            //    DolarTodayResult.DolarTodayResponse respuesta = new DolarTodayResult.DolarTodayResponse();
            //    respuesta.moneda = "dolar";
            //    respuesta.precio = data.result.value;
            //    return Json(respuesta);
            //}
            return  Ok(new {result = "Intente con la ruta cotizacion/dolar" });
        }
        [Route("cotizacion/dolar")]
        [HttpGet]
        public IHttpActionResult Dolar()
        {
            string url = "https://api.cambio.today/v1/quotes/USD/ARS/json?quantity=1&key=1996|bXyeYQ8Ve*eK_GacjCfmfRtNYsq*vEnm";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsAsync<DolarTodayResult>().Result;
                DolarTodayResult.DolarTodayResponse respuesta = new DolarTodayResult.DolarTodayResponse();
                respuesta.moneda = "dolar";
                respuesta.precio = data.result.value;
                return Json(respuesta);
            }
            return Ok(new { result = "No Data Found" });
        }
        [Route("cotizacion/euro")]
        [HttpGet]
        public IHttpActionResult Euro()
        {
            string url = "https://api.cambio.today/v1/quotes/EUR/ARS/json?quantity=1&key=1996|bXyeYQ8Ve*eK_GacjCfmfRtNYsq*vEnm";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsAsync<DolarTodayResult>().Result;
                DolarTodayResult.DolarTodayResponse respuesta = new DolarTodayResult.DolarTodayResponse();
                respuesta.moneda = "euro";
                respuesta.precio = data.result.value;
                return Json(respuesta);
            }
            return Ok(new { result = "No Data Found" });
        }
        [Route("cotizacion/real")]
        [HttpGet]
        public IHttpActionResult Real()
        {
            string url = "https://api.cambio.today/v1/quotes/BRL/ARS/json?quantity=1&key=1996|bXyeYQ8Ve*eK_GacjCfmfRtNYsq*vEnm";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsAsync<DolarTodayResult>().Result;
                DolarTodayResult.DolarTodayResponse respuesta = new DolarTodayResult.DolarTodayResponse();
                respuesta.moneda = "real";
                respuesta.precio = data.result.value;
                return Json(respuesta);
            }
            return Ok(new { result = "No Data Found" });
        }

    }
}
