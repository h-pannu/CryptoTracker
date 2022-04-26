namespace CryptoTrackerNew.View;
using CryptoTrackerNew.ViewModel;

public partial class MainPage : ContentPage
{
	public MainPage(CryptoViewModel cryptoViewModel)
	{
		InitializeComponent();
		BindingContext = cryptoViewModel;
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}