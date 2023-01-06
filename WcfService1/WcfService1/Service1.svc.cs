using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ITemperatureConverter, ILengthConverter, IWeightConverter, IVolumeConverter
    {
        // Temperature conversion
        public double ConvertCelsiusToFahrenheit(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }

        public double ConvertFahrenheitToCelsius(double temperature)
        {
            return (temperature - 32) * 5 / 9;
        }

        // Length conversion
        public double ConvertMillimetreToCentimetre(double length)
        {
            return length / 10;
        }

        public double ConvertMillimetreToMetre(double length)
        {
            return length / 1000;
        }

        public double ConvertMillimetreToKilometre(double length)
        {
            return length / 1e+6;
        }

        public double ConvertCentimetreToMillimetre(double length)
        {
            return length * 10;
        }

        public double ConvertCentimetreToMetre(double length)
        {
            return length / 100;
        }

        public double ConvertCentimetreToKilometre(double length)
        {
            return length / 100000;
        }

        public double ConvertMetreToMillimetre(double length)
        {
            return length * 1000;
        }

        public double ConvertMetreToCentimetre(double length)
        {
            return length * 100;
        }

        public double ConvertMetreToKilometre(double length)
        {
            return length / 1000;
        }

        public double ConvertKilometreToMillimetre(double length)
        {
            return length * 1e+6;
        }

        public double ConvertKilometreToCentimetre(double length)
        {
            return length * 100000;
        }

        public double ConvertKilometreToMetre(double length)
        {
            return length * 1000;
        }

        public double ConvertInchToFoot(double length)
        {
            return length / 12;
        }

        public double ConvertInchToYard(double length)
        {
            return length / 36;
        }

        public double ConvertInchToMile(double length)
        {
            return length / 63360;
        }

        public double ConvertFootToInch(double length)
        {
            return length * 12;
        }

        public double ConvertFootToYard(double length)
        {
            return length / 3;
        }

        public double ConvertFootToMile(double length)
        {
            return length / 5280;
        }

        public double ConvertYardToInch(double length)
        {
            return length * 36;
        }

        public double ConvertYardToFoot(double length)
        {
            return length * 3;
        }

        public double ConvertYardToMile(double length)
        {
            return length / 1760;
        }

        public double ConvertMileToInch(double length)
        {
            return length * 63360;
        }

        public double ConvertMileToFoot(double length)
        {
            return length * 5280;
        }

        public double ConvertMileToYard(double length)
        {
            return length * 1760;
        }

        public double ConvertMillimetreToInch(double length)
        {
            return length / 25.4;
        }

        public double ConvertMillimetreToFoot(double length)
        {
            return length / 304.8;
        }

        public double ConvertMillimetreToYard(double length)
        {
            return length / 914.4;
        }

        public double ConvertMillimetreToMile(double length)
        {
            return length / 1.609e+6;
        }

        public double ConvertCentimetreToInch(double length)
        {
            return length / 2.54;
        }

        public double ConvertCentimetreToFoot(double length)
        {
            return length / 30.48;
        }

        public double ConvertCentimetreToYard(double length)
        {
            return length / 91.44;
        }

        public double ConvertCentimetreToMile(double length)
        {
            return length / 160900;
        }

        public double ConvertMetreToInch(double length)
        {
            return length * 39.97;
        }

        public double ConvertMetreToFoot(double length)
        {
            return length * 3.281;
        }

        public double ConvertMetreToYard(double length)
        {
            return length * 1.094;
        }

        public double ConvertMetreToMile(double length)
        {
            return length / 1609;
        }

        public double ConvertKilometreToInch(double length)
        {
            return length * 39370;
        }

        public double ConvertKilometreToFoot(double length)
        {
            return length * 3281;
        }

        public double ConvertKilometreToYard(double length)
        {
            return length * 1094;
        }

        public double ConvertKilometreToMile(double length)
        {
            return length / 1.609;
        }

        public double ConvertInchToMillimetre(double length)
        {
            return length * 25.4;
        }

        public double ConvertInchToCentimetre(double length)
        {
            return length * 2.54;
        }

        public double ConvertInchToMetre(double length)
        {
            return length / 39.37;
        }

        public double ConvertInchToKilometre(double length)
        {
            return length / 39370;
        }

        public double ConvertFootToMillimetre(double length)
        {
            return length * 304.8;
        }

        public double ConvertFootToCentimetre(double length)
        {
            return length * 30.48;
        }

        public double ConvertFootToMetre(double length)
        {
            return length / 3.281;
        }

        public double ConvertFootToKilometre(double length)
        {
            return length / 3281;
        }

        public double ConvertYardToMillimetre(double length)
        {
            return length * 914.4;
        }

        public double ConvertYardToCentimetre(double length)
        {
            return length * 91.44;
        }

        public double ConvertYardToMetre(double length)
        {
            return length / 1.094;
        }

        public double ConvertYardToKilometre(double length)
        {
            return length / 1094;
        }

        public double ConvertMileToMillimetre(double length)
        {
            return length * 1.609e+6;
        }

        public double ConvertMileToCentimetre(double length)
        {
            return length * 160900;
        }

        public double ConvertMileToMetre(double length)
        {
            return length * 1609;
        }

        public double ConvertMileToKilometre(double length)
        {
            return length * 1.609;
        }

        // Weight conversion
        public double ConvertMilligramToGram(double weight)
        {
            return weight / 1000;
        }

        public double ConvertMilligramToKilogram(double weight)
        {
            return weight / 1e+6;
        }

        public double ConvertMilligramToTonne(double weight)
        {
            return weight / 1e+9;
        }

        public double ConvertGramToMilligram(double weight)
        {
            return weight * 1000;
        }

        public double ConvertGramToKilogram(double weight)
        {
            return weight / 1000;
        }

        public double ConvertGramToTonne(double weight)
        {
            return weight / 1e+6;
        }

        public double ConvertKilogramToMilligram(double weight)
        {
            return weight * 1e+6;
        }

        public double ConvertKilogramToGram(double weight)
        {
            return weight * 1000;
        }

        public double ConvertKilogramToTonne(double weight)
        {
            return weight / 1000;
        }

        public double ConvertTonneToMilligram(double weight)
        {
            return weight * 1e+9;
        }

        public double ConvertTonneToGram(double weight)
        {
            return weight * 1e+6;
        }

        public double ConvertTonneToKilogram(double weight)
        {
            return weight * 1000;
        }

        public double ConvertOunceToPound(double weight)
        {
            return weight / 16;
        }

        public double ConvertOunceToStone(double weight)
        {
            return weight / 224;
        }

        public double ConvertPoundToOunce(double weight)
        {
            return weight * 16;
        }

        public double ConvertPoundToStone(double weight)
        {
            return weight / 14;
        }

        public double ConvertStoneToOunce(double weight)
        {
            return weight * 224;
        }

        public double ConvertStoneToPound(double weight)
        {
            return weight * 14;
        }

        public double ConvertMilligramToOunce(double weight)
        {
            return weight / 28350;
        }

        public double ConvertMilligramToPound(double weight)
        {
            return weight / 453600;
        }

        public double ConvertMilligramToStone(double weight)
        {
            return weight / 6.35e+6;
        }

        public double ConvertGramToOunce(double weight)
        {
            return weight / 28.35;
        }

        public double ConvertGramToPound(double weight)
        {
            return weight / 453.6;
        }

        public double ConvertGramToStone(double weight)
        {
            return weight / 6350;
        }

        public double ConvertKilogramToOunce(double weight)
        {
            return 35.274;
        }

        public double ConvertKilogramToPound(double weight)
        {
            return weight * 2.205;
        }

        public double ConvertKilogramToStone(double weight)
        {
            return weight / 6.35;
        }

        public double ConvertTonneToOunce(double weight)
        {
            return weight * 35270;
        }

        public double ConvertTonneToPound(double weight)
        {
            return weight * 2205;
        }

        public double ConvertTonneToStone(double weight)
        {
            return weight * 157.5;
        }

        public double ConvertOunceToMilligram(double weight)
        {
            return weight * 28350;
        }

        public double ConvertOunceToGram(double weight)
        {
            return weight * 28.35;
        }

        public double ConvertOunceToKilogram(double weight)
        {
            return weight / 35.274;
        }

        public double ConvertOunceToTonne(double weight)
        {
            return weight / 35270;
        }

        public double ConvertPoundToMilligram(double weight)
        {
            return weight * 453600;
        }

        public double ConvertPoundToGram(double weight)
        {
            return weight * 453.6;
        }

        public double ConvertPoundToKilogram(double weight)
        {
            return weight / 2.205;
        }

        public double ConvertPoundToTonne(double weight)
        {
            return weight / 2205;
        }

        public double ConvertStoneToMilligram(double weight)
        {
            return weight * 6.35e+6;
        }

        public double ConvertStoneToGram(double weight)
        {
            return weight * 6350;
        }

        public double ConvertStoneToKilogram(double weight)
        {
            return weight * 6.35;
        }

        public double ConvertStoneToTonne(double weight)
        {
            return weight / 157.5;
        }

        // Volume conversion
        public double ConvertMillilitreToLitre(double volume)
        {
            return volume / 1000;
        }

        public double ConvertLitreToMillilitre(double volume)
        {
            return volume * 1000;
        }

        public double ConvertPintToQuart(double volume)
        {
            return volume / 2;
        }

        public double ConvertPintToGallon(double volume)
        {
            return volume / 8;
        }

        public double ConvertQuartToPint(double volume)
        {
            return volume * 2;
        }

        public double ConvertQuartToGallon(double volume)
        {
            return volume / 4;
        }

        public double ConvertGallonToPint(double volume)
        {
            return volume * 8;
        }

        public double ConvertGallonToQuart(double volume)
        {
            return volume * 4;
        }

        public double ConvertMillilitreToPint(double volume)
        {
            return volume / 568.3;
        }

        public double ConvertMillilitreToQuart(double volume)
        {
            return volume / 1137;
        }

        public double ConvertMillilitreToGallon(double volume)
        {
            return volume / 4546;
        }

        public double ConvertLitreToPint(double volume)
        {
            return volume / 568.3;
        }

        public double ConvertLitreToQuart(double volume)
        {
            return volume / 1.136;
        }

        public double ConvertLitreToGallon(double volume)
        {
            return volume / 4.546;
        }

        public double ConvertPintToMillilitre(double volume)
        {
            return volume * 568.3;
        }

        public double ConvertPintToLitre(double volume)
        {
            return volume / 1.76;
        }

        public double ConvertQuartToMillilitre(double volume)
        {
            return volume * 1137;
        }

        public double ConvertQuartToLitre(double volume)
        {
            return volume * 1.137;
        }

        public double ConvertGallonToMillilitre(double volume)
        {
            return volume * 4546;
        }

        public double ConvertGallonToLitre(double volume)
        {
            return volume * 4.546;
        }
    }
}
