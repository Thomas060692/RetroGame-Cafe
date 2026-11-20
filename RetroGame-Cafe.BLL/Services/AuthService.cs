using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.BLL.Mapper;
using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMemberRepository _member;
        private readonly IHasherHelper _hasherHelper;

        public AuthService(IMemberRepository member, IHasherHelper hasherHelper)
        {
            _member = member;
            _hasherHelper = hasherHelper;
        }

        public MemberModel? Login(string Email, string Password)
        {
            MemberModel? mem = _member.GetALL().SingleOrDefault(m => m.Email == Email)?.ToModel();

            if (mem is null)
            {
                return null;
            }

            bool pswVerfied = _hasherHelper.Verify(mem.PasswordHash, Password);
            if (!pswVerfied)
            {
                return null;
            }

            mem.PasswordHash = string.Empty;

            return mem;
        }

        public MemberModel? Register(MemberModel model, string Password)
        {
            MemberModel? memberAlreadyExists = _member.GetALL().SingleOrDefault(m => m.Email == model.Email)?.ToModel();

            if (memberAlreadyExists is not null)
            {
                return null;
            }

            model.PasswordHash = _hasherHelper.Hash(Password);
            _member.CreateMember(model.ToEntity());

            model.PasswordHash = string.Empty;

            return model;
        }
    }
}
