using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MdP.Interfaces;
using MdP;
using Moq;

namespace UserServiceTest
{
    [TestFixture]
    public class FunctionTests
    {
        [SetUp]
        public void Init()
        {
            
        }
        [Test]
        public void GetUser123Test()
        {
            IUserConfiguration userConf = new UserConfiguration();
            string result = userConf.GetUserInformation(123);

            Assert.That(result, Is.EqualTo("Hans Wurst"));
        }

        [Test]
        public void GetEmptyUserTest()
        {
            IUserConfiguration userconf = new UserConfiguration();
            string result = userconf.GetUserInformation(1);

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void GetUser123MockTest()
        {
            var mock = new Mock<IUserConfiguration>();
            mock.Setup(
                e => e.GetUserInformation(123)
                ).Returns("Hans Wurst");

            Assert.That(mock.Object.GetUserInformation(123), Is.EqualTo("Hans Wurst"));
        }
    }
}
