using MauiApp3.Data;
using MauiApp3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp3.Commands
{
    public class EditPlayerCommandHandler
    {
        private readonly PlayerRepository _playerRepository;

        public EditPlayerCommandHandler(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public void Handle(EditPlayerCommand command)
        {
            var player = _playerRepository.Players.FirstOrDefault(player => player.Id == command.Id);
            if (player != null)
            {
                return;
            };
            Player player1 = new Player
            {
                Id = command.Id,
                Name = command.Name,
                Level = command.Level
            };
            _playerRepository.Players.Remove(player1);

            Player playerupdate = new Player
            {
                Id = command.Id,
                Name = command.Name,
                Level = command.Level
            };
           
            _playerRepository.Players.Add(playerupdate);
        }
    }
}