using Microsoft.EntityFrameworkCore;
using ToDtoExtension.Data;
using ToDtoExtension.Entities;

namespace UserWebApp.Data;

public class UserData(DatabaseContext databaseContext) : IUserData
{
    public async Task Create(UserEntity userEntity)
    {
        databaseContext.Users.Add(userEntity);
        await databaseContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<UserEntity>> GetAll()
    {
        return await databaseContext.Users.ToListAsync();
    }
}
