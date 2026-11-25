<<<<<<< HEAD
using MauiApp3.Data;
using MauiApp3.Model;
=======
﻿using MauiApp3.Data;
using MauiApp3.Model;
using System;
using System.Collections.Generic;
using System.Text;
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918

namespace MauiApp3.Commands
{
    public class AddPlayerCommandHandler
    {
        private readonly PlayerRepository _playerRepository;
<<<<<<< HEAD

=======
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
        public AddPlayerCommandHandler(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
<<<<<<< HEAD

        public void Handle(AddPlayerCommand command)
        {
            var player = new Player
            {
                Id = _playerRepository.Players.Count == 0
                    ? 1
                    : _playerRepository.Players.Max(p => p.Id) + 1,
=======
        public void Handle(AddPlayerCommand command)
        {
            Player player = new Player
            {
                Id = _playerRepository.Players.Count + 1,
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
                Name = command.Name,
                Level = command.Level,
            };

            _playerRepository.Players.Add(player);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
