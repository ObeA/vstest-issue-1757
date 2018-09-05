namespace vstest_issue_1757
{
    using Xunit;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };
        }
    }
}