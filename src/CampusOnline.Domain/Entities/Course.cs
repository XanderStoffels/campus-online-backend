using CampusOnline.Domain.Common;

namespace CampusOnline.Domain.Entities;

public class Course : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

}
