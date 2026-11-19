using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.BLL.Mapper
{
    internal static class MemberMapper
    {
        public static MemberEntity ToEntity(this MemberModel data)
        {
            return new MemberEntity()
            {
                Id = data.Id,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Email = data.Email,
                PasswordHash = data.PasswordHash,
                Pseudo = data.Pseudo,
                Role = data.Role,
            };
        }

        public static MemberModel ToModel(this MemberEntity data)
        {
            return new MemberModel()
            {
                Id = data.Id,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Email = data.Email,
                PasswordHash = data.PasswordHash,
                Pseudo = data.Pseudo,
                Role = data.Role,
            };
        }
    }
}
