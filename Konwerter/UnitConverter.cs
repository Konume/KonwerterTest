using System;

public class UnitConverter
{
    // Metoda konwertująca jednostki długości z metrów na centymetry
    public static double MetersToCentimeters(double meters)
    {
        return meters * 100;
    }

    // Metoda konwertująca jednostki długości z centymetrów na metry
    public static double CentimetersToMeters(double centimeters)
    {
        return centimeters / 100;
    }

    // Metoda konwertująca jednostki masy z kilogramów na funty
    public static double KilogramsToPounds(double kilograms)
    {
        return kilograms * 2.20462;
    }

    // Metoda konwertująca jednostki masy z funtów na kilogramy
    public static double PoundsToKilograms(double pounds)
    {
        return pounds / 2.20462;
    }

    // Metoda konwertująca jednostki temperatury z stopni Celsjusza na stopnie Fahrenheita
    public static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    // Metoda konwertująca jednostki temperatury z stopni Fahrenheita na stopnie Celsjusza
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
