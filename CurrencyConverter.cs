using System.Net.Http;
using System.Net.Http.Json;

namespace WebShop
{
    public class CurrencyConverter
    {
        decimal euroRate = 0;
        decimal usdRate = 0;

        public decimal ConvertToEUR(decimal sek)
        {
            if(euroRate == 0)
            {
                GetExchangeRate();
            }

            return Math.Round(sek * euroRate, 2);
        }
        public decimal ConvertToUSD(decimal sek)
        {
            if (usdRate == 0)
            {
                GetExchangeRate();
            }

            return Math.Round( sek * usdRate,2);
        }

        private async void GetExchangeRate()
        {
            using (var client = new HttpClient())
            {
                string endpoint = "https://api.freecurrencyapi.com/v1/latest?apikey=ERUkRQmP7OYvWWuBUfhiIwL1dyqxqReevmfeGvbp&currencies=EUR%2CUSD&base_currency=SEK";
                var response = await client.GetFromJsonAsync<CurrencyResponse>(endpoint);

                if (response != null)
                {
                    euroRate = response.data.EUR;
                    usdRate = response.data.USD;
                }
            }
            

            
        }
    }

    public class CurrencyData
    {
        public decimal EUR { get; set; }
        public decimal USD { get; set; }
    }

    public class CurrencyResponse
    {
        public CurrencyData data { get; set; }
    }
}
