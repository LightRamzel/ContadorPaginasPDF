﻿using GestaoPDF.Client.Data;
using MudBlazor.Services;
using GestaoPDF.Client.Data.Views;
using GestaoPDF.Client.Data.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using GestaoPDF.Application.IServices;
using GestaoPDF.Application.Services;
using GestaoPDF.Domain.Entities;

namespace GestaoPDF.Client
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
                });

            builder.Services.AddMudServices();
            builder.Services.AddMauiBlazorWebView();

            #if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
            #endif

            #if WINDOWS
            builder.Services.AddTransient<IFolderPicker, GestaoPDF.Client.Platforms.Windows.Services.FolderPicker>();
            #endif

            builder.Services.AddSingleton<List<ArquivoView>>();
            builder.Services.AddSingleton<IServiceBase<LeituraDocumento>, LeituraDocumentoService>();

            return builder.Build();
        }
    }
}