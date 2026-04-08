using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHub.Domain.Models
{
    public record Project(
        Guid Id,
        String Name,
        IReadOnlyList<Objective> Objectives);

    public record Objective(
        string description,
        bool isCompleted);

}
