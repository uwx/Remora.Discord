//
//  SPDX-FileName: DictionaryAutocompleteProvider.cs
//  SPDX-FileCopyrightText: Copyright (c) Jarl Gullberg
//  SPDX-License-Identifier: MIT
//

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FuzzySharp;
using Humanizer;
using Remora.Discord.API.Abstractions.Objects;
using Remora.Discord.API.Objects;
using Remora.Discord.Commands.Autocomplete;

namespace Remora.Discord.Samples.SlashCommands;

/// <summary>
/// Provides autocompletion against a dictionary of words.
/// </summary>
public class DictionaryAutocompleteProvider : IAutocompleteProvider
{
    private readonly IReadOnlySet<string> _dictionary = new SortedSet<string>
    {
        "a",
        "adipiscing",
        "aliquam",
        "amet",
        "at",
        "condimentum",
        "congue",
        "consectetur",
        "curabitur",
        "dapibus",
        "diam",
        "dolor",
        "egestas",
        "eget",
        "eleifend",
        "elit",
        "et",
        "finibus",
        "iaculis",
        "in",
        "ipsum",
        "lectus",
        "libero",
        "lorem",
        "nam",
        "nec",
        "neque",
        "nisl",
        "nullam",
        "nunc",
        "odio",
        "orci",
        "porta",
        "posuere",
        "quam",
        "quis",
        "semper",
        "sit",
        "sollicitudin",
        "tempor",
        "tempus",
        "ultricies",
        "velit",
        "venenatis",
        "vestibulum",
        "vitae"
    };

    /// <inheritdoc />
    public string Identity => "autocomplete::dictionary";

    /// <inheritdoc/>
    public ValueTask<IReadOnlyList<IApplicationCommandOptionChoice>> GetSuggestionsAsync
    (
        IReadOnlyList<IApplicationCommandInteractionDataOption> options,
        string userInput,
        CancellationToken ct = default
    )
    {
        return new ValueTask<IReadOnlyList<IApplicationCommandOptionChoice>>
        (
            _dictionary
                .OrderByDescending(n => Fuzz.Ratio(userInput, n))
                .Take(25)
                .Select(n => new ApplicationCommandOptionChoice(n.Humanize().Transform(To.TitleCase), n))
                .ToList()
        );
    }
}
