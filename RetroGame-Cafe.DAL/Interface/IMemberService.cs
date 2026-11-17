using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Interface
{
    public interface IMemberService
    {
        IEnumerable<MemberEntity> GetALL();
        MemberEntity? GetMemberById(int id);
        int CreatMemeber(MemberEntity data);
        bool UpdateMemeber(int id, MemberEntity data);
        bool DeleteMemeber(int id);
    }
}
