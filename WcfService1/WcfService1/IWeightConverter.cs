using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfService1
{
    [ServiceContract]
    public interface IWeightConverter
    {
        // Convert between metric units

        // Milligram conversion
        [OperationContract]
        double ConvertMilligramToGram(double weight);
        [OperationContract]
        double ConvertMilligramToKilogram(double weight);
        [OperationContract]
        double ConvertMilligramToTonne(double weight);

        // Gram conversion
        [OperationContract]
        double ConvertGramToMilligram(double weight);
        [OperationContract]
        double ConvertGramToKilogram(double weight);
        [OperationContract]
        double ConvertGramToTonne(double weight);

        // Kilogram conversion
        [OperationContract]
        double ConvertKilogramToMilligram(double weight);
        [OperationContract]
        double ConvertKilogramToGram(double weight);
        [OperationContract]
        double ConvertKilogramToTonne(double weight);

        // Tonne conversion
        [OperationContract]
        double ConvertTonneToMilligram(double weight);
        [OperationContract]
        double ConvertTonneToGram(double weight);
        [OperationContract]
        double ConvertTonneToKilogram(double weight);

        // Convert between imperial units

        // Ounce conversion
        [OperationContract]
        double ConvertOunceToPound(double weight);
        [OperationContract]
        double ConvertOunceToStone(double weight);

        // Pound conversion
        [OperationContract]
        double ConvertPoundToOunce(double weight);
        [OperationContract]
        double ConvertPoundToStone(double weight);

        // Stone
        [OperationContract]
        double ConvertStoneToOunce(double weight);
        [OperationContract]
        double ConvertStoneToPound(double weight);

        // Convert between metric and imperial units

        // Milligram conversion
        [OperationContract]
        double ConvertMilligramToOunce(double weight);
        [OperationContract]
        double ConvertMilligramToPound(double weight);
        [OperationContract]
        double ConvertMilligramToStone(double weight);

        // Gram conversion
        [OperationContract]
        double ConvertGramToOunce(double weight);
        [OperationContract]
        double ConvertGramToPound(double weight);
        [OperationContract]
        double ConvertGramToStone(double weight);

        // Kilogram conversion
        [OperationContract]
        double ConvertKilogramToOunce(double weight);
        [OperationContract]
        double ConvertKilogramToPound(double weight);
        [OperationContract]
        double ConvertKilogramToStone(double weight);

        // Tonne conversion
        [OperationContract]
        double ConvertTonneToOunce(double weight);
        [OperationContract]
        double ConvertTonneToPound(double weight);
        [OperationContract]
        double ConvertTonneToStone(double weight);

        // Ounce conversion
        [OperationContract]
        double ConvertOunceToMilligram(double weight);
        [OperationContract]
        double ConvertOunceToGram(double weight);
        [OperationContract]
        double ConvertOunceToKilogram(double weight);
        [OperationContract]
        double ConvertOunceToTonne(double weight);

        // Pound conversion
        [OperationContract]
        double ConvertPoundToMilligram(double weight);
        [OperationContract]
        double ConvertPoundToGram(double weight);
        [OperationContract]
        double ConvertPoundToKilogram(double weight);
        [OperationContract]
        double ConvertPoundToTonne(double weight);

        // Stone conversion
        [OperationContract]
        double ConvertStoneToMilligram(double weight);
        [OperationContract]
        double ConvertStoneToGram(double weight);
        [OperationContract]
        double ConvertStoneToKilogram(double weight);
        [OperationContract]
        double ConvertStoneToTonne(double weight);

    }
}