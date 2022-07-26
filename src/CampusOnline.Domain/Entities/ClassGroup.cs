using CampusOnline.Domain.Common;

namespace CampusOnline.Domain.Entities;

public class ClassGroup : BaseEntity
{
    public string Name { get; set; } = null!;
    public Teacher HeadTeacher { get; set; } = null!;
    public string HeadTeacherId { get; set; } = string.Empty;
    public DateOnly ActiveFrom { get; set; }
    public DateOnly ActiveUntil { get; set; }
    public IList<Student> Students { get; private set; } = new List<Student>();
}
