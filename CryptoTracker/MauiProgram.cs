namespace CryptoTracker;
using CryptoTracker.Services;
using CryptoTracker.ViewModel;
using CryptoTracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<CryptoService>();
		builder.Services.AddSingleton<CryptoViewModel>();
		//builder.Services.AddSingleton<CryptoList>();

		return builder.Build();
	}
}
