using System.Text.Json.Serialization;

namespace dotnet_rbg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        mage,
        Cleric
    }
}
