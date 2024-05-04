using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class UnitConverterTests
{
    [TestMethod]
    public void TestMetersToCentimeters()
    {
        Assert.AreEqual(100, UnitConverter.MetersToCentimeters(1));
        Assert.AreEqual(200, UnitConverter.MetersToCentimeters(2));
        Assert.AreEqual(0, UnitConverter.MetersToCentimeters(0));
    }

    [TestMethod]
    public void TestCentimetersToMeters()
    {
        Assert.AreEqual(1, UnitConverter.CentimetersToMeters(100));
        Assert.AreEqual(2, UnitConverter.CentimetersToMeters(200));
        Assert.AreEqual(0, UnitConverter.CentimetersToMeters(0));
    }

    [TestMethod]
    public void TestKilogramsToPounds()
    {
        Assert.AreEqual(2.20462, UnitConverter.KilogramsToPounds(1), 0.0001);
        Assert.AreEqual(4.40924, UnitConverter.KilogramsToPounds(2), 0.0001);
        Assert.AreEqual(0, UnitConverter.KilogramsToPounds(0));
    }

    [TestMethod]
    public void TestPoundsToKilograms()
    {
        Assert.AreEqual(1, UnitConverter.PoundsToKilograms(2.20462), 0.0001);
        Assert.AreEqual(2, UnitConverter.PoundsToKilograms(4.40924), 0.0001);
        Assert.AreEqual(0, UnitConverter.PoundsToKilograms(0));
    }

    [TestMethod]
    public void TestCelsiusToFahrenheit()
    {
        Assert.AreEqual(32, UnitConverter.CelsiusToFahrenheit(0));
        Assert.AreEqual(212, UnitConverter.CelsiusToFahrenheit(100));
        Assert.AreEqual(-40, UnitConverter.CelsiusToFahrenheit(-40));
    }

    [TestMethod]
    public void TestFahrenheitToCelsius()
    {
        Assert.AreEqual(0, UnitConverter.FahrenheitToCelsius(32));
        Assert.AreEqual(100, UnitConverter.FahrenheitToCelsius(212));
        Assert.AreEqual(-40, UnitConverter.FahrenheitToCelsius(-40));
    }
}
