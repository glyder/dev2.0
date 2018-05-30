using System;
using System.Diagnostics;

namespace VisRes.Core.Infrastructure.Diagnostics
{
    public class DisposableStopwatch : IDisposable
        {
            private readonly Stopwatch sw;
            private readonly Action<TimeSpan> f;
            private readonly string msg;

            public DisposableStopwatch(Action<TimeSpan> f, string msg = "")
            {
                this.f = f;
                this.msg = msg;
                if (this.msg != "") Console.WriteLine(msg);

                sw = Stopwatch.StartNew();
            }

            public void Dispose()
            {
                sw.Stop();
                f(sw.Elapsed);
            }
        }
}
