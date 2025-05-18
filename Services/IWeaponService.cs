using WebApi.Dtos.Character;
using WebApi.Dtos.Weapon;

namespace WebApi.Services
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
