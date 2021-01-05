using GYM_GetYourMuscles.Domain.Model;

namespace GYM_GetYourMuscles.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetByEmail(string email);
    }
}
