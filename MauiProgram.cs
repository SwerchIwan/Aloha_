using Microsoft.Extensions.Logging;
using static Aloha_.Todo;

namespace Aloha_;

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
                fonts.AddFont("ubuntu-medium.ttf", "ubuntu");
            });

#if DEBUG
		builder.Logging.AddDebug();
        builder.Services.AddSingleton<TodoItemDatabase>();
#endif

        return builder.Build();
	}
}
