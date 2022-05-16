using static Levi_Inventarization_Backend.OptionsClassCreator;

namespace Levi_Inventarization_Backend
{
    public interface IOptionsClassCreator
    {
        JwtOptions getJwtOptions();
        ConfigurationOptions getConfigurationOptions();
        JwtConfiguration getJwtConfiguration();
    }
}
