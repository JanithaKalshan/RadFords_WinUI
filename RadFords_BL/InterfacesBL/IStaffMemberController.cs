using RadFordsBusinessLayer.Dtos;

namespace RadFordsBusinessLayer.InterfacesBL
{
    public interface IStaffMemberController
    {
        public (bool, string) AddUpdateStaffMember(StaffMemberUpdateDto obj);
        public (bool, string, List<StaffMemberGetDto>?) GetStaffMembersWithPagination(int pageSize, int pageNo);
        public (bool, string, List<StaffMemberGetDto>?) GetStaffMembersByType(string type);
        public (bool, string) DeleteStaffMember(int id);
        public int GetRecordCount();
    }
}
