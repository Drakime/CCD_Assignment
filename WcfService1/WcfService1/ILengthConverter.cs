using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfService1
{
    [ServiceContract]
    public interface ILengthConverter
    {
        // Convert between metric units

        // Millimetre conversion
        [OperationContract]
        double ConvertMillimetreToCentimetre(double length);
        [OperationContract]
        double ConvertMillimetreToMetre(double length);
        [OperationContract]
        double ConvertMillimetreToKilometre(double length);

        // Centimetre conversion
        [OperationContract]
        double ConvertCentimetreToMillimetre(double length);
        [OperationContract]
        double ConvertCentimetreToMetre(double length);
        [OperationContract]
        double ConvertCentimetreToKilometre(double length);

        // Metre conversion
        [OperationContract]
        double ConvertMetreToMillimetre(double length);
        [OperationContract]
        double ConvertMetreToCentimetre(double length);
        [OperationContract]
        double ConvertMetreToKilometre(double length);

        // Kilometre conversion
        [OperationContract]
        double ConvertKilometreToMillimetre(double length);
        [OperationContract]
        double ConvertKilometreToCentimetre(double length);
        [OperationContract]
        double ConvertKilometreToMetre(double length);

        // Convert between imperial units

        // Inch conversion
        [OperationContract]
        double ConvertInchToFoot(double length);
        [OperationContract]
        double ConvertInchToYard(double length);
        [OperationContract]
        double ConvertInchToMile(double length);

        // Foot conversion
        [OperationContract]
        double ConvertFootToInch(double length);
        [OperationContract]
        double ConvertFootToYard(double length);
        [OperationContract]
        double ConvertFootToMile(double length);

        // Yard conversion
        [OperationContract]
        double ConvertYardToInch(double length);
        [OperationContract]
        double ConvertYardToFoot(double length);
        [OperationContract]
        double ConvertYardToMile(double length);

        // Mile conversion
        [OperationContract]
        double ConvertMileToInch(double length);
        [OperationContract]
        double ConvertMileToFoot(double length);
        [OperationContract]
        double ConvertMileToYard(double length);

        // Convert between metric and imperial units

        // Millimetre conversion
        [OperationContract]
        double ConvertMillimetreToInch(double length);
        [OperationContract]
        double ConvertMillimetreToFoot(double length);
        [OperationContract]
        double ConvertMillimetreToYard(double length);
        [OperationContract]
        double ConvertMillimetreToMile(double length);

        // Centimetre conversion
        [OperationContract]
        double ConvertCentimetreToInch(double length);
        [OperationContract]
        double ConvertCentimetreToFoot(double length);
        [OperationContract]
        double ConvertCentimetreToYard(double length);
        [OperationContract]
        double ConvertCentimetreToMile(double length);

        // Metre conversion
        [OperationContract]
        double ConvertMetreToInch(double length);
        [OperationContract]
        double ConvertMetreToFoot(double length);
        [OperationContract]
        double ConvertMetreToYard(double length);
        [OperationContract]
        double ConvertMetreToMile(double length);

        // Kilometre conversion
        [OperationContract]
        double ConvertKilometreToInch(double length);
        [OperationContract]
        double ConvertKilometreToFoot(double length);
        [OperationContract]
        double ConvertKilometreToYard(double length);
        [OperationContract]
        double ConvertKilometreToMile(double length);

        // Inch conversion
        [OperationContract]
        double ConvertInchToMillimetre(double length);
        [OperationContract]
        double ConvertInchToCentimetre(double length);
        [OperationContract]
        double ConvertInchToMetre(double length);
        [OperationContract]
        double ConvertInchToKilometre(double length);

        // Foot conversion
        [OperationContract]
        double ConvertFootToMillimetre(double length);
        [OperationContract]
        double ConvertFootToCentimetre(double length);
        [OperationContract]
        double ConvertFootToMetre(double length);
        [OperationContract]
        double ConvertFootToKilometre(double length);

        // Yard conversion
        [OperationContract]
        double ConvertYardToMillimetre(double length);
        [OperationContract]
        double ConvertYardToCentimetre(double length);
        [OperationContract]
        double ConvertYardToMetre(double length);
        [OperationContract]
        double ConvertYardToKilometre(double length);

        // Mile conversion
        [OperationContract]
        double ConvertMileToMillimetre(double length);
        [OperationContract]
        double ConvertMileToCentimetre(double length);
        [OperationContract]
        double ConvertMileToMetre(double length);
        [OperationContract]
        double ConvertMileToKilometre(double length);
    }
}