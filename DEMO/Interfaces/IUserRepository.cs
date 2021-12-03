using DEMO.Models;
using DEMO.Models.ViewModels;
using System.Threading.Tasks;

namespace DEMO.Interfaces
{
    public interface IUserRepository
    {

       Task<bool> SaveUser(RegistrationsVM data);

        Task<bool> UserExist(RegistrationsVM data);

        Task<Hero> GetUserById(string name);

        Task<bool> SaveAcheivement(HeroAcheivementVM data, string photoUrl);

        Task<bool> SaveAcheivement(HeroAcheivement data);

        Task<Hero> CompleteHeroProfileById(int id);

    }
}
