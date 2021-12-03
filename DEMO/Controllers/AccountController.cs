using DEMO.Interfaces;
using DEMO.Models;
using DEMO.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private IConfiguration _config;
        private readonly IWebHostEnvironment webHostEnvironment;


        public AccountController(IWebHostEnvironment webHost, IUserRepository userRepository, IConfiguration configuration)
        {
            this.userRepository = userRepository;
            this._config = configuration;
            this.webHostEnvironment = webHost;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> GetSingleUser([FromBody]string name)
        {
            var data = await this.userRepository.GetUserById(name);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser([FromBody] RegistrationsVM data)
        {
            Hero hero = new Hero();
            var result = await userRepository.UserExist(data);

            if(result)
            {
                hero = await userRepository.GetUserById(data.Name);
               
                //authClaims.Add(new Claim(ClaimTypes.Role, "user"));

                var authToken = GenerateJSONWebToken(hero);
                return Ok(new LogedInUserVM() { Id = hero.Id, Name = hero.Name,Password = hero.Password, Token = authToken });
            }
            return Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult>RegistrationUser([FromBody] RegistrationsVM data)
        {
            await this.userRepository.SaveUser(data);

            return Ok();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SaveHeroAcheivements([FromBody] HeroAcheivement data)
        {
            
            await this.userRepository.SaveAcheivement(data);
            return Ok();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> CompleteHeroProfile(int id)
        {
            var data = await this.userRepository.CompleteHeroProfileById(id);
            return Ok(data);
        }

        //[HttpPost]
        //public async Task<IActionResult> SaveHeroAcheivements([FromBody] HeroAcheivementVM data)
        //{
        //    if (System.IO.Directory.Exists(Path.Combine(webHostEnvironment.WebRootPath, "ProductImages")) == false)
        //    {
        //        System.IO.Directory.CreateDirectory(Path.Combine(webHostEnvironment.WebRootPath, "ProductImages"));
        //    }
        //    string uplaodsFolder = Path.Combine(webHostEnvironment.WebRootPath, "ProductImages");
        //    string uniquerfile = Guid.NewGuid().ToString() + "_" + data.file.FileName;
        //    string filePath = Path.Combine(uplaodsFolder, uniquerfile);
        //    using FileStream fileStreem = new FileStream(Path.Combine(uplaodsFolder, uniquerfile), FileMode.Create);
        //    data.file.CopyTo(fileStreem);

        //    var imgUrl = "/ProductImages/" + uniquerfile;
        //    await this.userRepository.SaveAcheivement(data, imgUrl);
        //    return Ok();
        //}

        private string GenerateJSONWebToken(Hero  userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
