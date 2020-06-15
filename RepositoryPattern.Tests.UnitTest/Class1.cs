using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RepositoryPattern.Tests.UnitTest
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(3, 1));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 3));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
