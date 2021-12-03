using DEMO.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DEMO.Controllers
{
    public class UsersControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
    public IActionResult Registrtion()
        {
            return View(new RegistrationsVM());
        }

        [HttpPost]
        public IActionResult Registrtion(RegistrationsVM model)
        {
            //  using (var httpClient = new HttpClient())
            //{
            //    StringContent content = new StringContent(JsonConvert.SerializeObject(reservation), Encoding.UTF8, "application/json");

            //    using (var response = await httpClient.PostAsync("https://localhost:44331/api/Reservation", content))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        receivedReservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);

            //    }
            //}

            // Below method is an alternate for post  

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/Account");
                var postTask = client.PostAsJsonAsync<RegistrationsVM>("SaveHero", model);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(RegistrationsVM model)
        {
            return View();
        }
    }
}
