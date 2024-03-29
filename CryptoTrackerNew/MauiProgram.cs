﻿using CryptoTrackerNew.Services;
using CryptoTrackerNew.View;
using CryptoTrackerNew.ViewModel;

namespace CryptoTrackerNew
{
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
            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddTransient<CryptoDetailslViewModel>();
            builder.Services.AddTransient<CryptoDetails>();

            return builder.Build();
        }
    }
}