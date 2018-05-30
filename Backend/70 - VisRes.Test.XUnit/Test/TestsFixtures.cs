using System;
using Xunit;

namespace Vrs.Test.XUnit.Test
{
    public class TestsFixture : IDisposable
    {
        public TestsFixture()
        {
            // Do "global" initialization here; Only called once.
        }

        public void Dispose()
        {
            // Do "global" teardown here; Only called once.
        }
    }

    public class DummyTests : IClassFixture<TestsFixture>
    {
        public void SetFixture(TestsFixture data)
        {
        }
    }
}
