namespace RadFordsBusinessLayer.Dtos;

public record StaffMemberCreateDto
{
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
}
