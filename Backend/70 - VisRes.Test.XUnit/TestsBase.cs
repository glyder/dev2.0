using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisRes.Test.XUnit
{
    public abstract class TestsBase : IDisposable
    {
        protected TestsBase()
        {
            // Do "global" initialization here; Called before every test method.
        }

        public void Dispose()
        {
            // Do "global" teardown here; Called after every test method.
        }
    }

    public class DummyTests : TestsBase
    {
        // Add test methods
    }
}
