using System;
using System.Collections.Generic;
using System.Text;

namespace test_cov.Models
{
    public class RateInfo
    {
        public class Confirmed
        {
            public int value { get; set; }
            public string detail { get; set; }

        }

        public class Recovered
        {
            public int value { get; set; }
            public string detail { get; set; }
        }

        public class Deaths
        {
            public int value { get; set; }
            public string detail { get; set; }
        }

        public class DailyTimeSeries
        {
            public string pattern { get; set; }
            public string example { get; set; }
        }

        public class CountryDetail
        {
            public string pattern { get; set; }
            public string example { get; set; }
        }

        public class RootObject
        {
            public Confirmed confirmed { get; set; }
            public Recovered recovered { get; set; }
            public Deaths deaths { get; set; }
            public string dailySummary { get; set; }
            public DailyTimeSeries dailyTimeSeries { get; set; }
            public string image { get; set; }
            public string source { get; set; }
            public string countries { get; set; }
            public CountryDetail countryDetail { get; set; }
            public DateTime lastUpdate { get; set; }
        }
    }
}
