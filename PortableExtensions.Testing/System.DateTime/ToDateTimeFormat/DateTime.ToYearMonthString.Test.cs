﻿#region Using

using System;
using System.Globalization;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class DateTimeExTest
    {
        [Test]
        public void ToYearMonthStringTestCase()
        {
            var dateTime = DateTime.Now;
            var expected = dateTime.ToString( "y" );
            var actual = dateTime.ToYearMonthString();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void ToYearMonthStringTestCase1()
        {
            var dateTime = DateTime.Now;
            var expected = dateTime.ToString( "y", DateTimeFormatInfo.CurrentInfo );
            var actual = dateTime.ToYearMonthString( DateTimeFormatInfo.CurrentInfo );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void ToYearMonthStringTestCase2()
        {
            var dateTime = DateTime.Now;
            var expected = dateTime.ToString( "y", CultureInfo.InvariantCulture );
            var actual = dateTime.ToYearMonthString( CultureInfo.InvariantCulture );
            Assert.AreEqual( expected, actual );
        }
    }
}