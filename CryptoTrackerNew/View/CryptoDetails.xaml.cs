namespace CryptoTrackerNew;
using CryptoTrackerNew.ViewModel;

public partial class CryptoDetails : ContentPage
{
	public CryptoDetails(CryptoDetailslViewModel cryptodetailsViewModel)
	{
		InitializeComponent();
		BindingContext = cryptodetailsViewModel;
	}
}