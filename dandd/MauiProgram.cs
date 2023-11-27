using Microsoft.Extensions.Logging;

namespace dandd
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            ConfigurationBuilder.ConfigureApp(builder);

#if DEBUG
		ConfigurationBuilder.ConfigureDebugger(builder);
#endif

            return builder.Build();
        }
    }
}