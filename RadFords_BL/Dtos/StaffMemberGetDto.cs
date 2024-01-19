namespace RadFordsBusinessLayer.Dtos;

public record StaffMemberGetDto : StaffMemberUpdateDto
{
    public string FullName => $"{FirstName} {LastName}";
}
