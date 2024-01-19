using RadFordDataAccessLayer.Interfaces;
using RadFordDataAccessLayer.Models;
using RadFordDataAccessLayer.Repository;
using RadFordsBusinessLayer.Dtos;
using RadFordsBusinessLayer.InterfacesBL;
using RadFordsBusinessLayer.Mapper;

namespace RadFordsBusinessLayer.Controller;

public class StaffMemberController : IStaffMemberController
{

    #region >> Properties
    IStaffMemberRepository _staffmemberRepo;

    #endregion

    #region >> Contructors

    public StaffMemberController()
    {
        _staffmemberRepo = new StaffMemberRepository();
    }

    #endregion

    #region >> LocalMethods

    public (bool, string) AddUpdateStaffMember(StaffMemberUpdateDto obj)
    {

        try
        {
            var entity = new StaffMember
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

            if (entity.StaffMemberId == 0)
            {
                _staffmemberRepo.Add(entity);
            }
            else
            {
                _staffmemberRepo.Update(entity);
            }

            return (true, "");
        }
        catch (Exception ex)
        {

            return (false, ex.Message);
        }
    }

    public (bool, string, List<StaffMemberGetDto>?) GetStaffMembersWithPagination(int pageSize, int pageNo)
    {
        try
        {
            var lst = _staffmemberRepo.GetAllWithPagination(pageSize, pageNo);
            var convertlst = Map.ConvertListStaffMemberToStaffMemberGetDto(lst);
            return (true, "", convertlst);
        }
        catch (Exception ex)
        {

            return (false, ex.Message, null);
        }
    }

    public (bool, string, List<StaffMemberGetDto>?) GetStaffMembersByType(string type)
    {
        try
        {
            var lst = _staffmemberRepo.GetAllByStaffType(type);
            var convertlst = Map.ConvertListStaffMemberToStaffMemberGetDto(lst);
            return (true, "", convertlst);
        }
        catch (Exception ex)
        {

            return (false, ex.Message, null);
        }
    }

    public (bool, string) DeleteStaffMember(int id)
    {
        try
        {
            var message = _staffmemberRepo.Delete(id);
            return (message==""?true:false, message);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    public int GetRecordCount()
    {
       return _staffmemberRepo.GetTotalRecordCount();
    }

    #endregion
}
