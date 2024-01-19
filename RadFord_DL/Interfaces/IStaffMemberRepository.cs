using RadFordDataAccessLayer.Models;

namespace RadFordDataAccessLayer.Interfaces;

public interface IStaffMemberRepository: IRepository<StaffMember>
{
    public IEnumerable<StaffMember> GetAllByStaffType(string type);
    public int GetTotalRecordCount();
}
