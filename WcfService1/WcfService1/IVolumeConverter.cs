using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfService1
{
    [ServiceContract]
    public interface IVolumeConverter
    {
        // Convert between metric units

        // Millilitre conversion
        [OperationContract]
        double ConvertMillilitreToLitre(double volume);

        // Litre conversion
        [OperationContract]
        double ConvertLitreToMillilitre(double volume);

        // Convert between imperial units

        // Pint conversion
        [OperationContract]
        double ConvertPintToQuart(double volume);
        [OperationContract]
        double ConvertPintToGallon(double volume);

        // Quart conversion
        [OperationContract]
        double ConvertQuartToPint(double volume);
        [OperationContract]
        double ConvertQuartToGallon(double volume);

        // Gallon conversion
        [OperationContract]
        double ConvertGallonToPint(double volume);
        [OperationContract]
        double ConvertGallonToQuart(double volume);

        // Convert between metric and imperial units

        // Millilitre conversion
        [OperationContract]
        double ConvertMillilitreToPint(double volume);
        [OperationContract]
        double ConvertMillilitreToQuart(double volume);
        [OperationContract]
        double ConvertMillilitreToGallon(double volume);

        // Litre conversion
        [OperationContract]
        double ConvertLitreToPint(double volume);
        [OperationContract]
        double ConvertLitreToQuart(double volume);
        [OperationContract]
        double ConvertLitreToGallon(double volume);

        // Pint conversion
        [OperationContract]
        double ConvertPintToMillilitre(double volume);
        [OperationContract]
        double ConvertPintToLitre(double volume);

        // Quart conversion
        [OperationContract]
        double ConvertQuartToMillilitre(double volume);
        [OperationContract]
        double ConvertQuartToLitre(double volume);

        // Gallon conversion
        [OperationContract]
        double ConvertGallonToMillilitre(double volume);
        [OperationContract]
        double ConvertGallonToLitre(double volume);
    }
}