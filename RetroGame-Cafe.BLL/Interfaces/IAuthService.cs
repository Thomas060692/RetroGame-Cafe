using RetroGame_Cafe.BLL.Models;

namespace RetroGame_Cafe.BLL.Interfaces
{
    public interface IAuthService
    {
        MemberModel? Login(string Email, string Password);
        MemberModel? Register(MemberModel model, string Password);
    }
}
