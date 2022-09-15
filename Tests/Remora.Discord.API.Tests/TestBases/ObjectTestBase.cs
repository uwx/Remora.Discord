//
//  ObjectTestBase.cs
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

using JetBrains.Annotations;
using Remora.Discord.API.Tests.Services;

namespace Remora.Discord.API.Tests.TestBases;

/// <summary>
/// Tests the <typeparamref name="TType"/> type.
/// </summary>
/// <typeparam name="TType">The type under test.</typeparam>
[UsedImplicitly(ImplicitUseTargetFlags.WithInheritors)]
public abstract class ObjectTestBase<TType> : JsonBackedTypeTestBase<TType, SampleObjectDataSource<TType>>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ObjectTestBase{TType}"/> class.
    /// </summary>
    /// <param name="fixture">The test fixture.</param>
    protected ObjectTestBase(JsonBackedTypeTestFixture fixture)
        : base(fixture)
    {
    }
}
