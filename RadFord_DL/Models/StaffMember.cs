using System.ComponentModel.DataAnnotations.Schema;

namespace RadFordDataAccessLayer.Models;

[Table("StaffMember")]
public class StaffMember
{
    public int StaffMemberId { get; set; }
    public string? StaffType { get; set; } 
    public string? Title { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleInitial { get; set; }
    public string? HomePhone { get; set; }
    public string? CellPhone { get; set; }
    public string? OfficeExtension { get; set; }
    public string? IRDNumber { get; set; }
    public string? Status { get; set; }

    public int? ManagerId { get; set; }

    public StaffMember? Manager { get; set; }


    public ICollection<StaffMember> Subordinates { get; set; }
}
