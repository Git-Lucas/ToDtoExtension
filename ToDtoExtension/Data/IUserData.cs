using ToDtoExtension.Entities;

namespace ToDtoExtension.Data;
public interface IUserData
{
    Task Create(UserEntity userEntity);
    Task<IEnumerable<UserEntity>> GetAll();
}
