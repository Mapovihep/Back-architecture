namespace ConfigurationContainer
{
    public class GetConnectionString : IGetConnectionString
    {
        private string _connect;
        public GetConnectionString(string connect)
        {
            _connect = connect;
        }
        public string GetString()
        {
            return _connect;
        }
    }
}
