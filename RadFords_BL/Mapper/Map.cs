using RadFordDataAccessLayer.Models;
using RadFordsBusinessLayer.Dtos;

namespace RadFordsBusinessLayer.Mapper;

public class Map
{
    public static List<StaffMemberGetDto> ConvertListStaffMemberToStaffMemberGetDto(IEnumerable<StaffMember> entity) 
    {
        List<StaffMemberGetDto> lst = new List<StaffMemberGetDto>();
        foreach(var obj in entity)
        {
            var member = new StaffMemberGetDto
            {
                StaffMemberId = obj.StaffMemberId,
                Title = obj.Title,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                MiddleInitial = obj.MiddleInitial,
                HomePhone = obj.HomePhone,
                CellPhone = obj.CellPhone,
                IRDNumber = obj.IRDNumber,
                OfficeExtension = obj.OfficeExtension,
                Status = obj.Status,
                StaffType = obj.StaffType,
                ManagerId = obj.ManagerId
            };
            lst.Add(member);
        }
        return lst;
    }
}
