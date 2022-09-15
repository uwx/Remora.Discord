﻿//
//  VoiceSpeakingEventTests.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using Remora.Discord.API.Abstractions.VoiceGateway.Events;
using Remora.Discord.API.Tests.TestBases;
using Remora.Discord.API.VoiceGateway.Events;

namespace Remora.Discord.API.Tests.VoiceGateway.Events;

/// <summary>
/// Tests the <see cref="VoiceSpeakingEvent"/> event.
/// </summary>
public class VoiceSpeakingEventTests : VoiceGatewayEventTestBase<IVoiceSpeakingEvent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VoiceSpeakingEventTests"/> class.
    /// </summary>
    /// <param name="fixture">The test fixture.</param>
    public VoiceSpeakingEventTests(JsonBackedTypeTestFixture fixture)
        : base(fixture)
    {
    }
}
