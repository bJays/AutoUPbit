using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using AutoUPBit;
//
//    var data = ChartData.FromJson(jsonString);
namespace AutoUPBit
{
    public partial class ChartData
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("candleDateTime")]
        public DateTime CandleDateTime { get; set; }

        [JsonProperty("candleDateTimeKst")]
        public DateTime CandleDateTimeKst { get; set; }

        [JsonProperty("openingPrice")]
        public long OpeningPrice { get; set; }

        [JsonProperty("highPrice")]
        public long HighPrice { get; set; }

        [JsonProperty("lowPrice")]
        public long LowPrice { get; set; }

        [JsonProperty("tradePrice")]
        public long TradePrice { get; set; }

        [JsonProperty("candleAccTradeVolume")]
        public double CandleAccTradeVolume { get; set; }

        [JsonProperty("candleAccTradePrice")]
        public double CandleAccTradePrice { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("unit")]
        public long Unit { get; set; }
    }

    public partial class ChartData
    {
        public static List<ChartData> FromJson(string json) => JsonConvert.DeserializeObject<List<ChartData>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<ChartData> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
