using DEMO.Interfaces;
using DEMO.Models;
using DEMO.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DEMO
{
    public class UserRepository : IUserRepository
    {
        private readonly DOMO_Context context;

        public UserRepository(DOMO_Context context)
        {
            this.context = context;
        }

        public async Task<Hero> GetUserById(string name)
        {
            return await this.context.Heros.Where(s => s.Name == name).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveAcheivement(HeroAcheivementVM data, string photoUrl)
        {
            this.context.HeroAcheivements.Add(new HeroAcheivement()
            {
                AcheivementDetail = data.Description,
                HeorId = data.HeroId,
                PhotoURL = photoUrl
            }) ;

         await   this.context.SaveChangesAsync();
            return true; 
        }

        public async Task<bool> SaveAcheivement(HeroAcheivement data)
        {
            this.context.HeroAcheivements.Add(data);
            await this.context.SaveChangesAsync();
            return true;
        }


        public async Task<Hero> CompleteHeroProfileById(int id)
        {
            return await this.context.Heros.Include(s=>s.Acheivements).Where(s=>s.Id ==id).FirstOrDefaultAsync();
        }

        public async  Task<bool> SaveUser(RegistrationsVM data)
        {
            this.context.Heros.Add(new Hero() { 
                 DOB = data.DOB,
                  Name = data.Name,
                  Password =data.Password
            });
                await   this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UserExist(RegistrationsVM data)
        {
            return await context.Heros.AnyAsync(s => s.Name.ToLower().Equals(data.Name) && s.Password.ToLower().Equals(data.Password));
        }
    }
}
