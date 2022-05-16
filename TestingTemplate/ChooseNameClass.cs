namespace TestingTemplate
{
    public class ChooseNameClass
    {
        private string[] _possibleNames;
        public ChooseNameClass(string[] possibleNames)
        {
            _possibleNames = possibleNames;
        }
        public string Chooser(string[] _possibleNames, int border)
        {
            Random rnd = new Random();
            //return _possibleNames[rnd.Next(0, _possibleNames.Length)];
            if(_possibleNames.Contains(_possibleNames[rnd.Next(0, border)]) != false)
            {
                return _possibleNames[rnd.Next(0, border)];
            }
            else
            {
                throw new Exception();
            }
        }
        //{ "George", "Rusik", "Ukranian", "Bratislava", "Love"};
    }
}
