﻿#region Using

using System;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class DoubleExTest
    {
        [Test]
        public void ToHoursTestCase()
        {
            var number = 10.5;
            var expected = TimeSpan.FromHours( number );
            var actual = number.ToHours();

            Assert.AreEqual( expected, actual );
        }
    }
}