using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy;
using Moq;
using NUnit.Framework;

namespace StrategyTest
{
    [TestFixture]
    public class StrategyTests
    {
        [SetUp]
        public void Init()
        {

        }

        [Test]
        public void AlgorithmFunctionTest()
        {
            var con = new Context();
            con.Algorithm();
            
        }

        [Test]
        public void SwitchFunctionTest()
        {
            var con = new Context();
            con.SwitchStrategy();
        }

    }
}
