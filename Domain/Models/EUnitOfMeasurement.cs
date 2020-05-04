
using System.ComponentModel;


namespace AcarSutMarket.API.Domain.Models
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("AD")]
        Adet = 1,

        [Description("MG")]
        Miligram = 2,

        [Description("G")]
        Gram = 3,

        [Description("KG")]
        Kilogram = 4,
        
        [Description("Lt")]
        Litre = 5,
    }
}