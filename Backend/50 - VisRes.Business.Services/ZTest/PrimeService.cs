using System;

namespace VisRes.Business.Services.Test
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            //if (candidate == 1)
            //{
            //    return false;
            //}
            //throw new NotImplementedException("Please create a test first");

            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
