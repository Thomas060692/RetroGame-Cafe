using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Interface
{
    public interface IMemberRepository
    {
        IEnumerable<MemberEntity> GetALL();
        MemberEntity? GetMemberById(int id);
        int CreateMember(MemberEntity data);
        bool UpdateMember(int id, MemberEntity data);
        bool DeleteMember(int id);
    }
}
