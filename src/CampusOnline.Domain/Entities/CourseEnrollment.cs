using CampusOnline.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusOnline.Domain.Entities;

public class CourseEnrollment : BaseEntity
{
    public Teacher TeachedBy { get; set; } = null!;
    public string TeachedById { get; set; } = null!;
    public ClassGroup TeachedTo { get; set; } = null!;
    public string TeachedToId { get; set; } = null!;
}
