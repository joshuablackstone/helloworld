namespace HelloWorld.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly string value = "Hello World";
        public string GetValue()
        {
            return value;
        }
    }
}
