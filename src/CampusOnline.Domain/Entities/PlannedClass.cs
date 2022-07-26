using CampusOnline.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusOnline.Domain.Entities;

internal class PlannedClass : BaseEntity
{
    public Teacher Teacher { get; set; } = null!;
    public string TeacherId { get; set; } = null!;
    public Course Course { get; set; } = null!;
    public string CourseId { get; set; } = null!;
    public ClassGroup ClassGroup { get; set; } = null!;
    public string ClassGroupId { get; set; } = null!;

    public bool IsCancelled { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public TimeSpan Duration => To - From;
}
