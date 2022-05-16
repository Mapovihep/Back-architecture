
namespace Levi_Inventarization_Backend
{
    public class test
    {
        private readonly IConfiguration Configuration;
        private readonly IOptionsClassCreator _optionsClassCreator;
        public test(IConfiguration configuration, IOptionsClassCreator optionsClassCreator)
        {
            Configuration = configuration;
            _optionsClassCreator = optionsClassCreator;
        }
        public string OnGet()
        {
            var positionOptions = _optionsClassCreator.getConfigurationOptions();
            Configuration.GetSection(positionOptions.DefaultConnection).Bind(positionOptions);
            return $"Title: {positionOptions.DefaultConnection}";
        }
    }
}
