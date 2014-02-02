﻿using NUnit.Framework;

namespace GeoTimeZone.Tests
{
    [TestFixture]
    public class TimeZoneLookupTests
    {
        [Test]
        public void Can_Lookup_TimeZone_PaigntonPier()
        {
            var tz = TimeZoneLookup.GetTimeZone(50.4372, -3.5559);
            Assert.AreEqual("Europe/London", tz.IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_Phoenix()
        {
            var tz = TimeZoneLookup.GetTimeZone(33.45, -112.0667);
            Assert.AreEqual("America/Phoenix", tz.IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_NewYork()
        {
            var tz = TimeZoneLookup.GetTimeZone(40.67, -73.94);
            Assert.AreEqual("America/New_York", tz.IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_LosAngeles()
        {
            var tz = TimeZoneLookup.GetTimeZone(34.0500, -118.25);
            Assert.AreEqual("America/Los_Angeles", tz.IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_Honolulu()
        {
            var tz = TimeZoneLookup.GetTimeZone(21.3, -157.8167);
            Assert.AreEqual("Pacific/Honolulu", tz.IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_London()
        {
            var tz = TimeZoneLookup.GetTimeZone(51.5072, -0.1275);
            Assert.AreEqual("Europe/London", tz.IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_SaoPaulo()
        {
            var tz = TimeZoneLookup.GetTimeZone(-23.55, -46.6333);
            Assert.AreEqual("America/Sao_Paulo", tz.IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_Sydney()
        {
            var tz = TimeZoneLookup.GetTimeZone(-33.86, 151.2111);
            Assert.AreEqual("Australia/Sydney", tz.IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_LordHoweIsland()
        {
            var tz = TimeZoneLookup.GetTimeZone(-31.55, 159.0833);
            Assert.AreEqual("Australia/Lord_Howe", tz.IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_Mazatlan()
        {
            var tz = TimeZoneLookup.GetTimeZone(23.22, -106.42);
            Assert.AreEqual("America/Mazatlan", tz.IanaTimeZoneId);
        }
    }
}
