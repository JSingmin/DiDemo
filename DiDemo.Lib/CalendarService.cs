using System;
using DiDemo.Lib.Data;

namespace DiDemo.Lib
{
    public class CalendarServiceNoDependencyInjection
    {
        private SqlDataFetchService _dataFetchService = new SqlDataFetchService(
            new SqlDataServiceConfiguration("lol"));

        public bool IsLeapYear()
        {
            return DateTime.Now.Year % 4 == 0;
        }

        public string GetData()
        {
            return _dataFetchService.GetData();
        }
    }























    public class CalendarServiceDependencyInjection
    {
        private readonly IDataFetchService _dataFetchService;

        public CalendarServiceDependencyInjection(IDataFetchService dataFetchService)
        {
            _dataFetchService = dataFetchService;
        }

        public bool IsLeapYear(DateTime date)
        {
            return date.Year % 4 == 0;
        }

        public string GetData()
        {
            return _dataFetchService.GetData();
        }
    }
}
