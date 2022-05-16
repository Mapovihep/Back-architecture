namespace Levi_Inventarization_Backend
{
    public class OptionsClassCreator : IOptionsClassCreator
    {
        public class ConfigurationOptions
        {
            public const string ConnectionStrings = "ConnectionStrings";
            public string DefaultConnection { get; set; } = String.Empty;
        }
       
        public class JwtConfiguration
        {
            public const string JwtSettings = "JwtSettings";
            public string Secret { get; set; } = String.Empty;
            public string TokenLifetime { get; set; } = String.Empty;
        }
        
        public class JwtOptions
        {
            public const string Jwt = "Jwt";
            public string Issuer { get; set; } = String.Empty;
            public string Audience { get; set; } = String.Empty;
            public string Key { get; set; } = String.Empty;
        }
        public JwtOptions getJwtOptions()
        {
            return new JwtOptions();
        }
        public ConfigurationOptions getConfigurationOptions()
        {
            return new ConfigurationOptions();
        }
        public JwtConfiguration getJwtConfiguration()
        {
            return new JwtConfiguration();
        }
    }
}
