using Microsoft.Extensions.Logging;

using MisterioDoCaixa.Services;
using Microsoft.Maui.LifecycleEvents;

namespace MisterioDoCaixa;

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
			})
			.ConfigureLifecycleEvents(events =>
			{
#if WINDOWS
				events.AddWindows(windows => windows.OnWindowCreated(window =>
				{
					var windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);
					var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
					var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);

					if (appWindow.Presenter is Microsoft.UI.Windowing.OverlappedPresenter presenter)
					{
						presenter.Maximize();
					}
				}));
#endif
			});

		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddSingleton<CaixaService>();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
