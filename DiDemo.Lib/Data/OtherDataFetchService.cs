using System;

namespace DiDemo.Lib.Data
{
    public class OtherDataServiceConfiguration
    {
      public OtherDataServiceConfiguration(string username)
      {
        Username = username;
      }

      public string Username { get; private set; }
    }

    public class OtherDataFetchService : IDataFetchService
    {
      private readonly OtherDataServiceConfiguration _config;

      public OtherDataFetchService(OtherDataServiceConfiguration config)
      {
        _config = config;
      }

      public string GetData()
      {
        return $"Data from Other ({_config.Username})";
      }
    }
}
