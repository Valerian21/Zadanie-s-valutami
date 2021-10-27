using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Valutka
{
    class Main
    {
        string API_KEY = "1d2965cd4ccee6e70a1b";
        public decimal DeserialDataCurrency(string code)
        {
            var url = $"https://free.currconv.com/api/v7/convert?q={code}&compact=ultra&apiKey={API_KEY}";
            var webClient = new WebClient();
            var jsonData = string.Empty;
            decimal answer = decimal.Zero;
            try
            {
                jsonData = webClient.DownloadString(url);
                JObject currencyData = JObject.Parse(jsonData);
                answer = Convert.ToDecimal(currencyData[code]);
            }
            catch (Exception error)
            {
                System.Windows.MessageBox.Show(error.Message);
            }
            return answer;
        }
    }
}
