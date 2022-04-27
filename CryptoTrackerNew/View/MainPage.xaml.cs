namespace CryptoTrackerNew.View;
using CryptoTrackerNew.ViewModel;
using CryptoTrackerNew.Model;

public partial class MainPage : ContentPage
{
	public MainPage(CryptoViewModel cryptoViewModel)
	{
		InitializeComponent();
		BindingContext = cryptoViewModel;
	}

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
		var crypto = ((VisualElement)sender).BindingContext as Crypto;

		if (crypto == null)
			return;

		await Shell.Current.GoToAsync(nameof(CryptoDetails), true, new Dictionary<string, object>
		{
			{"Crypto", crypto }
		});
	}
}