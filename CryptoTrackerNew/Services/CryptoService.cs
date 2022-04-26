using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using CryptoTrackerNew.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CryptoTrackerNew.Services
{
    public class CryptoService
    {
        HttpClient _httpClient; 

        public CryptoService()
        {
            this._httpClient = new HttpClient();    
        }

        List<Crypto> _cryptoList;

        public async Task<List<Crypto>> GetCryptos()
        {
            if(_cryptoList?.Count > 0)
                return _cryptoList;

            var response = await _httpClient.GetAsync("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&per_page=100");
            if(response.IsSuccessStatusCode)
            {
                try
                {
                    string content = await response.Content.ReadAsStringAsync();
                    _cryptoList = JsonSerializer.Deserialize<List<Crypto>>(content);

                    //_cryptoList = await response.Content.ReadFromJsonAsync<List<Crypto>>();
                }
                catch (Exception ex)
                {

                    throw;
                }
                 
            }

            return _cryptoList;
        }
    }
}
