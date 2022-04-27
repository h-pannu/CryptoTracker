using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CryptoTrackerNew.Model;

namespace CryptoTrackerNew.ViewModel
{
    [QueryProperty(nameof(Crypto), "Crypto")]
    public partial class CryptoDetailslViewModel : BaseViewModel
    {
        public CryptoDetailslViewModel()
        {
        }

        [ObservableProperty]
        Crypto crypto;
    }
}
