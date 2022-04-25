namespace CryptoTracker;
using CryptoTracker.ViewModel;

public partial class CryptoList : ContentPage
{
	public CryptoList(CryptoViewModel cryptoViewModel)
	{
		InitializeComponent();
		BindingContext = cryptoViewModel;
	}
}