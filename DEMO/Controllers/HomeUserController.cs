using DEMO.Models;
using DEMO.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Controllers
{
    public class HomeUserController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeUserController(IWebHostEnvironment webHost)
        {
            this.webHostEnvironment = webHost;
        }

        [HttpGet]
        public async Task<IActionResult> UploadAcheivement(int HeroId)
        {
            HeroAcheivementVM model = new HeroAcheivementVM();
            model.HeroId = HeroId;

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> UploadAcheivement(HeroAcheivementVM data)
        {
            if (System.IO.Directory.Exists(Path.Combine(webHostEnvironment.WebRootPath, "ProductImages")) == false)
            {
                System.IO.Directory.CreateDirectory(Path.Combine(webHostEnvironment.WebRootPath, "ProductImages"));
            }
            string uplaodsFolder = Path.Combine(webHostEnvironment.WebRootPath, "ProductImages");
            string uniquerfile = Guid.NewGuid().ToString() + "_" + data.file.FileName;
            string filePath = Path.Combine(uplaodsFolder, uniquerfile);
            using FileStream fileStreem = new FileStream(Path.Combine(uplaodsFolder, uniquerfile), FileMode.Create);
            data.file.CopyTo(fileStreem);

            var imgUrl = "/ProductImages/" + uniquerfile;

            data.photoUrl = imgUrl;

            HeroAcheivement m = new HeroAcheivement();
            m.AcheivementDetail = data.Description;
            m.HeorId = data.HeroId;
            m.PhotoURL = data.photoUrl;

            var getD = HttpContext.Session.GetObject<LogedInUserVM>("AuthenticationToken");
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(m), Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", getD.Token.ToString());
                using (var response = await httpClient.PostAsync("https://localhost:44357/api/Account/SaveHeroAcheivements", content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return RedirectToAction("HeroProfiles", "HomeUser", new { id = data.HeroId });
                    }
                }
            }
            return View(data);
        }


        public async Task<IActionResult> HeroProfiles(int id)
        {
            var getD = HttpContext.Session.GetObject<LogedInUserVM>("AuthenticationToken");
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(getD.Name), Encoding.UTF8, "application/json");
                
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", getD.Token.ToString());
                using (var response = await httpClient.GetAsync("https://localhost:44357/api/Account/CompleteHeroProfile/" + id))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<Hero>(apiResponse);
                        return View(data);
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // Extracting the data from Session
            var getD = HttpContext.Session.GetObject<LogedInUserVM>("AuthenticationToken");
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(getD.Name), Encoding.UTF8, "application/json");
               
                // Binding Token in Api Header
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", getD.Token.ToString());
                
                using (var response = await httpClient.PostAsync("https://localhost:44357/api/Account/GetSingleUser", content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<Hero>(apiResponse);
                        return View(data);
                    }
                }
            }
            return View();
        }


        public async Task<IActionResult> Profile(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registrtion()
        {
            return View(new RegistrationsVM());
        }


        [HttpPost]
        public async Task<IActionResult> Registrtion(RegistrationsVM model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync("https://localhost:44357/api/Account/RegistrationUser/", content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return RedirectToAction("Login");
                    }

                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            return View(new RegistrationsVM());
        }

        [HttpPost]
        public async Task<IActionResult> Login(RegistrationsVM model)
        {

            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync("https://localhost:44357/api/Account/LoginUser/", content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<LogedInUserVM>(apiResponse);

                        // Store Authenticaton Token in Session 
                        HttpContext.Session.SetObject("AuthenticationToken",data);
                        return RedirectToAction("Index");
                    }

                }
            }
            return View();
        }
    }
}
