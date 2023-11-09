using System.Text.Json.Serialization;

namespace dotnet.models
{
    //Used to show the string of enum not the number
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        mage = 2,
        Cleric = 3
    }
}