<<<<<<< HEAD
using MauiApp3.Commands;
=======
﻿using MauiApp3.Commands;
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
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
<<<<<<< HEAD
            builder.UseMauiApp<App>();

            builder.Services.AddSingleton<PlayerRepository>();
            builder.Services.AddTransient<AddPlayerCommandHandler>();
            builder.Services.AddTransient<DeletePlayerCommandHandler>();
            builder.Services.AddTransient<EditPlayerCommandHandler>();
=======
            builder
                .UseMauiApp<App>();
            builder.Services.AddSingleton<PlayerRepository>();
            builder.Services.AddTransient<AddPlayerCommandHandler>();
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
            builder.Services.AddTransient<GetPlayerByIdQueryHandler>();
            builder.Services.AddTransient<GetPlayersQueryHandler>();
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPage>();

<<<<<<< HEAD
#if DEBUG
            builder.Logging.AddDebug();
#endif
=======

#if DEBUG
            builder.Logging.AddDebug();
#endif

>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
            return builder.Build();
        }
    }
}
