using ProjectHub.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHub.Domain.Interfaces
{
    public interface IProjectRepository
    {
        Task<Project?> GetByIdAsync(Guid id);
        Task SaveAsync(Project project);
        Task<IEnumerable<Project>> GetAllAsync();
        
    }
    
}
