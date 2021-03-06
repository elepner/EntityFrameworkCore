// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit.Abstractions;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class IncludeOracleTest : IncludeTestBase<IncludeOracleFixture>
    {
        // ReSharper disable once UnusedParameter.Local
        public IncludeOracleTest(IncludeOracleFixture fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
            //fixture.TestSqlLoggerFactory.SetTestOutputHelper(testOutputHelper);
        }

        public override void Include_duplicate_reference(bool useString)
        {
            // TODO: Investigate
        }
    }
}
