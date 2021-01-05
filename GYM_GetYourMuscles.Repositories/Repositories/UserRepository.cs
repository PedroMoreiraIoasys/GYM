using GYM_GetYourMuscles.Repositories.Interfaces;
using System.Linq;
using GYM_GetYourMuscles.Domain.Model;

namespace GYM_GetYourMuscles.Repositories.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(Context.Context context) : base(context)
        {

        }

        public User GetByEmail(string email)
        {
            return _dbSet.FirstOrDefault(c => c.Email == email);
        }
    }
}
