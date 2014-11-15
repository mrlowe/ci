using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyApp.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ThingTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(2 + 2, 4);
        }
    }
}
