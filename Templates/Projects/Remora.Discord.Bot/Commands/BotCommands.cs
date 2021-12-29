using System.Threading.Tasks;
using Remora.Commands.Attributes;
using Remora.Commands.Groups;
using Remora.Discord.Commands.Contexts;
using Remora.Discord.Commands.Feedback.Services;
using Remora.Results;

namespace Remora.Discord.Bot.Commands;

/// <summary>
/// Defines commands in the bot.
/// </summary>
public class BotCommands : CommandGroup
{
    private readonly FeedbackService _feedbackService;
    private readonly ICommandContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="BotCommands"/> class.
    /// </summary>
    /// <param name="feedbackService">The feedback service.</param>
    /// <param name="context">The command context.</param>
    public BotCommands(FeedbackService feedbackService, ICommandContext context)
    {
        _feedbackService = feedbackService;
        _context = context;
    }

    /// <summary>
    /// Sends a "Hello, world!" message.
    /// </summary>
    /// <returns>The result of the command.</returns>
    [Command("hello")]
    public async Task<IResult> SendHelloAsync()
    {
        return await _feedbackService.SendContextualNeutralAsync
        (
            "Hello, world!",
            _context.User.ID,
            ct: this.CancellationToken
        );
    }
}
