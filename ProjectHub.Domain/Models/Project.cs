using System.Collections.Immutable;

namespace ProjectHub.Domain.Models;

// Usamos PascalCase para as propriedades
public record Project(
    Guid Id,
    string Name,
    ImmutableList<Objective> Objectives)
{
    // Construtor compacto para garantir que Objectives nunca é null
    public Project(Guid id, string name, IEnumerable<Objective>? objectives = null)
        : this(id, name, objectives?.ToImmutableList() ?? ImmutableList<Objective>.Empty)
    {
    }
}

public record Objective(
    string Description,
    bool IsCompleted,
    bool IsBlurred);