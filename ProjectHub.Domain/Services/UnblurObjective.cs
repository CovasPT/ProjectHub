using ProjectHub.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHub.Domain.Services
{
    public Project UnblurObjective(Project project, int index)
    {
        // 1. Vai buscar o objetivo atual.
        var currentObjective = project.Objectives[index];

        // 2. Cria uma CÓPIA do objetivo sem o blur (usando 'with').
        var updatedObjective = currentObjective with { IsBlurred = false };

        // 3. Como é que criarias uma NOVA versão do 'project' 
        // com a lista de objetivos atualizada, sem usar um loop 'for'?

        return project with
        {
            Objectives = project.Objectives.SetItem(index, updatedObjective)
        };
    }
}
