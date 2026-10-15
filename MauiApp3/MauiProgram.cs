using MauiApp3.Commands;
using MauiApp3.Data;
using MauiApp3.Queries;
using MauiApp3.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiApp3
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>();
            builder.Services.AddSingleton<PlayerRepository>();
            builder.Services.AddTransient<AddPlayerCommandHandler>();
            builder.Services.AddTransient<GetPlayerByIdQueryHandler>();
            builder.Services.AddTransient<GetPlayersQueryHandler>();
<<<<<<< HEAD
            builder.Services.AddTransient<DeletePlayerCommandHandler>();
            builder.Services.AddTransient<EditPlayerCommandHandler>();
=======
>>>>>>> fad0de232215eb6968a828c6e703b465d7d19ac2
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPage>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
