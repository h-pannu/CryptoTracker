using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoTrackerNew.Model;
using CryptoTrackerNew.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace CryptoTrackerNew.ViewModel
{
    public partial class CryptoViewModel : BaseViewModel
    {
        public ObservableCollection<Crypto> Cryptos { get; } = new();
        CryptoService cryptoService;

        public CryptoViewModel(CryptoService cryptoService)
        {
            this.cryptoService = cryptoService;
        }

        [ObservableProperty]
        bool isRefreshing;

        [ICommand]
        async Task GetCryptoAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                var cryptos = await cryptoService.GetCryptos();

                Cryptos.Clear();
                foreach (var crypto in cryptos)
                {
                    Cryptos.Add(crypto);
                }
            }
            catch ( Exception ex)
            {
                Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
                isRefreshing= false;
            }
        }

    }
}
