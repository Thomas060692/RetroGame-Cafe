using Microsoft.EntityFrameworkCore.ChangeTracking;
using RetroGame_Cafe.DAL.Entities;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.DAL.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext _context;

        public MemberRepository(AppDbContext context)
        {
            _context = context;
        }

        public int CreateMember(MemberEntity data)
        {
            EntityEntry<MemberEntity> member = _context.Members.Add(data);

            _context.SaveChanges();

            return member.Entity.Id;
        }

        public bool DeleteMember(int id)
        {
            MemberEntity? mem = _context.Members.SingleOrDefault(m => m.Id == id);

            if (mem is null)
            {
                return false;
            }

            _context.Members.Remove(mem);
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<MemberEntity> GetALL()
        {
            return _context.Members.ToList();
        }

        public MemberEntity? GetMemberById(int id)
        {
            return _context.Members.SingleOrDefault(m => m.Id == id);
        }

        public bool UpdateMember(int id, MemberEntity data)
        {
            MemberEntity mem = new MemberEntity()
            {
                Id = id,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Pseudo = data.Pseudo,
                Email = data.Email,
                PasswordHash = data.PasswordHash,
                Role = data.Role,
            };

            _context.Update(mem);
            _context.SaveChanges();

            return true;
        }
    }
}
