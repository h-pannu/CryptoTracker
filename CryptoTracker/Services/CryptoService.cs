using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using CryptoTracker.Model;

namespace CryptoTracker.Services
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

            var response = await _httpClient.GetAsync("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&per_page=2000");
            if(response.IsSuccessStatusCode)
            {
                _cryptoList= await response.Content.ReadFromJsonAsync<List<Crypto>>(); 
            }

            return _cryptoList;
        }
    }
}
