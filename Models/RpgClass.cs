
using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RpgCLass
{
    Knight = 1,

    Mage = 2,

    Cleric = 3
}