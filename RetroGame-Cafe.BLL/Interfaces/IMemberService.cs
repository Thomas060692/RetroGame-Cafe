using RetroGame_Cafe.BLL.Models;

namespace RetroGame_Cafe.BLL.Interfaces
{
    public interface IMembersService
    {
        IEnumerable<MemberModel> GetALL();
        MemberModel? GetMemberById(int id);
        int CreatMemeber(MemberModel data);
        bool UpdateMemeber(int id, MemberModel data);
        bool DeleteMemeber(int id);
    }
}
