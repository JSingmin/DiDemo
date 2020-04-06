using System;

namespace DiDemo.Lib.Data
{
    public class SqlDataServiceConfiguration
    {
      public SqlDataServiceConfiguration(string server)
      {
        Server = server;
      }

      public string Server { get; private set; }
    }

    public class SqlDataFetchService : IDataFetchService
    {
      private readonly SqlDataServiceConfiguration _config;

      public SqlDataFetchService(SqlDataServiceConfiguration config)
      {
        _config = config;
      }

      public string GetData()
      {
        return $"Data from SQL (Server: {_config.Server})";
      }
    }
}
