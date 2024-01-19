namespace RadFordsBusinessLayer.Dtos;

public record StaffMemberUpdateDto : StaffMemberCreateDto
{
    public int StaffMemberId { get; set; }
}
