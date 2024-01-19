using RadFordDataAccessLayer.Interfaces;
using RadFordDataAccessLayer.Models;

namespace RadFordDataAccessLayer.Repository;

public class StaffMemberRepository: Repository<StaffMember>,IStaffMemberRepository
{
    public IEnumerable<StaffMember> GetAllByStaffType(string? type)
    {
        using (var _context = new RDbContext())
        {
           return _context.StaffMembers.Where(x=>x.StaffType == type).ToList();
        }
    }

    public int GetTotalRecordCount()
    {
        using (var _context = new RDbContext())
        {
            return _context.StaffMembers.Count();
        }
    }
}
