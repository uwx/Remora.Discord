using Remora.Commands.Groups;
using Remora.Discord.Commands.Contexts;

namespace Remora.Discord.Templates.Items.RemoraCommandGroup;

/// <summary>
/// Defines a set of commands.
/// </summary>
public class RemoraCommandGroup : CommandGroup
{
    private readonly ICommandContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="RemoraCommandGroup"/> class.
    /// </summary>
    /// <param name="context">The context of the command.</param>
    public RemoraCommandGroup(ICommandContext context)
    {
        _context = context;
    }
}
