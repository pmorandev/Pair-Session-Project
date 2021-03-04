using System;
using Xunit;
using Services.Math;

namespace Services.Test
{
    public class SumTest
    {
        [Fact]
        public void sumCorrect()
        {
            var result = Sum.sumDoubles(2,2);
            Assert.Equal(4, result);
        }

        [Fact]
        public void sumFail(){
            var result = Sum.sumDoubles(1,2);
            Assert.Equal(4, result);
        }
    }
}
