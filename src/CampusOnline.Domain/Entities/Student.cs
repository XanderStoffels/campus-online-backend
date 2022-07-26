using CampusOnline.Domain.Common;

namespace CampusOnline.Domain.Entities;

public class Student : BaseEntity
{
    public string StudentNumber { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}
