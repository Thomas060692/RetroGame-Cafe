using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.BLL.Mapper;
using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.BLL.Services
{
    public class MemberService : IMembersService
    {
        private readonly IMemberRepository _memberService;

        public MemberService(IMemberRepository memberService)
        {
            _memberService = memberService;
        }

        public int CreatMemeber(MemberModel data)
        {
            int id = _memberService.CreateMember(data.ToEntity());

            data.Id = id;
            return id;
        }

        public bool DeleteMemeber(int id)
        {
            return _memberService.DeleteMember(id);
        }

        public IEnumerable<MemberModel> GetALL()
        {
            return _memberService.GetALL().Select(m => m.ToModel()).ToList();
        }

        public MemberModel? GetMemberById(int id)
        {
            MemberModel? mem = _memberService.GetMemberById(id)?.ToModel();

            if (mem is null)
            {
                return null;
            }

            return mem;
        }

        public bool UpdateMemeber(int id, MemberModel data)
        {
            try
            {
                _memberService.UpdateMember(id, data.ToEntity());
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
