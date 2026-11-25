<<<<<<< HEAD
using MauiApp3.Commands;
using MauiApp3.Model;
using MauiApp3.Queries;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
=======
﻿
using MauiApp3.Commands;
using MauiApp3.Model;
using MauiApp3.Queries;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
using System.Windows.Input;

namespace MauiApp3.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly GetPlayerByIdQueryHandler _getPlayerByIdQueryHandler;
        private readonly GetPlayersQueryHandler _getPlayersQueryHandler;
        private readonly AddPlayerCommandHandler _addPlayerCommandHandler;
<<<<<<< HEAD
        private readonly DeletePlayerCommandHandler _deletePlayerCommandHandler;
        private readonly EditPlayerCommandHandler _editPlayerCommandHandler;
=======
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Player> Players { get; } = new();
<<<<<<< HEAD

        private string _playerName = "";
        public string PlayerName
        {
            get => _playerName;
            set { _playerName = value; OnPropertyChanged(); }
        }

        private string _playerLevel = "";
        public string PlayerLevel
        {
            get => _playerLevel;
            set { _playerLevel = value; OnPropertyChanged(); }
        }

        private string _playerId = "";
        public string PlayerId
        {
            get => _playerId;
            set { _playerId = value; OnPropertyChanged(); }
        }

        private string _deletePlayerId = "";
        public string DeletePlayerId
        {
            get => _deletePlayerId;
            set { _deletePlayerId = value; OnPropertyChanged(); }
        }

        private string _editPlayerId = "";
        public string EditPlayerId
        {
            get => _editPlayerId;
            set { _editPlayerId = value; OnPropertyChanged(); }
        }

        private string _editPlayerName = "";
        public string EditPlayerName
        {
            get => _editPlayerName;
            set { _editPlayerName = value; OnPropertyChanged(); }
        }

        private string _editPlayerLevel = "";
        public string EditPlayerLevel
        {
            get => _editPlayerLevel;
            set { _editPlayerLevel = value; OnPropertyChanged(); }
        }

        private string _searchResult = "";
        public string SearchResult
        {
            get => _searchResult;
            set { _searchResult = value; OnPropertyChanged(); }
        }

        private string _operationResult = "";
        public string OperationResult
        {
            get => _operationResult;
            set { _operationResult = value; OnPropertyChanged(); }
        }

        public ICommand AddPlayerCommandButton { get; }
        public ICommand FindPlayerCommandButton { get; }
        public ICommand DeletePlayerCommandButton { get; }
        public ICommand EditPlayerCommandButton { get; }

        public MainViewModel(
            GetPlayerByIdQueryHandler getPlayerByIdQueryHandler,
            GetPlayersQueryHandler getPlayersQueryHandler,
            AddPlayerCommandHandler addPlayerCommandHandler,
            DeletePlayerCommandHandler deletePlayerCommandHandler,
            EditPlayerCommandHandler editPlayerCommandHandler)
=======
        public string PlayerName { get; set; } = "";
        public string PlayerLevel { get; set; } = "";
        public string PlayerId { get; set; } = "";
        private string _searchResult = "";

        public string SearchResult
        {
            get
            {
                return _searchResult;
            }

            set
            {
                _searchResult = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddPlayerCommandButton { get; }
        public ICommand FindPlayerCommandButton { get; }
        public MainViewModel(
            GetPlayerByIdQueryHandler getPlayerByIdQueryHandler,
            GetPlayersQueryHandler getPlayersQueryHandler,
            AddPlayerCommandHandler addPlayerCommandHandler)
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
        {
            _getPlayerByIdQueryHandler = getPlayerByIdQueryHandler;
            _getPlayersQueryHandler = getPlayersQueryHandler;
            _addPlayerCommandHandler = addPlayerCommandHandler;
<<<<<<< HEAD
            _deletePlayerCommandHandler = deletePlayerCommandHandler;
            _editPlayerCommandHandler = editPlayerCommandHandler;

            AddPlayerCommandButton = new Command(AddPlayer);
            FindPlayerCommandButton = new Command(FindPlayer);
            DeletePlayerCommandButton = new Command(DeletePlayer);
            EditPlayerCommandButton = new Command(EditPlayer);

            LoadPlayers();
        }

        private void AddPlayer()
        {
            if (string.IsNullOrWhiteSpace(PlayerName))
            {
                OperationResult = "Podaj nazwę gracza.";
                return;
            }

            if (!int.TryParse(PlayerLevel, out int level) || level < 0)
            {
                OperationResult = "Podaj poprawny, nieujemny poziom gracza.";
                return;
            }

            _addPlayerCommandHandler.Handle(
                new AddPlayerCommand(PlayerName.Trim(), level));

            PlayerName = "";
            PlayerLevel = "";
            OperationResult = "Dodano gracza.";
            LoadPlayers();
        }

        private void FindPlayer()
        {
            if (!int.TryParse(PlayerId, out int id) || id <= 0)
            {
                SearchResult = "Niepoprawne ID.";
                return;
            }

            var player = _getPlayerByIdQueryHandler.Handle(
                new GetPlayerByIdQuery(id));

            SearchResult = player == null
                ? "Nie znaleziono gracza."
                : $"{player.Name} - poziom {player.Level}";
        }

        private void DeletePlayer()
        {
            if (!int.TryParse(DeletePlayerId, out int id) || id <= 0)
            {
                OperationResult = "Podaj poprawne ID gracza do usunięcia.";
                return;
            }

            bool deleted = _deletePlayerCommandHandler.Handle(
                new DeletePlayerCommand(id));

            OperationResult = deleted
                ? $"Usunięto gracza o ID {id}."
                : $"Nie znaleziono gracza o ID {id}.";

            if (deleted)
            {
                DeletePlayerId = "";
                LoadPlayers();
            }
        }

        private void EditPlayer()
        {
            if (!int.TryParse(EditPlayerId, out int id) || id <= 0)
            {
                OperationResult = "Podaj poprawne ID gracza do edycji.";
                return;
            }

            if (string.IsNullOrWhiteSpace(EditPlayerName))
            {
                OperationResult = "Podaj nową nazwę gracza.";
                return;
            }

            if (!int.TryParse(EditPlayerLevel, out int level) || level < 0)
            {
                OperationResult = "Podaj poprawny, nieujemny poziom gracza.";
                return;
            }

            bool edited = _editPlayerCommandHandler.Handle(
                new EditPlayerCommand(id, EditPlayerName.Trim(), level));

            OperationResult = edited
                ? $"Zaktualizowano gracza o ID {id}."
                : $"Nie znaleziono gracza o ID {id}.";

            if (edited)
            {
                EditPlayerId = "";
                EditPlayerName = "";
                EditPlayerLevel = "";
                LoadPlayers();
            }
=======

            AddPlayerCommandButton = new Command(AddPlayer);
            FindPlayerCommandButton = new Command(FindPlayer);


            LoadPlayers();
        }
        private void AddPlayer()
        {
            if (!int.TryParse(PlayerLevel, out int playerLevel))
            {
                return;
            }
            AddPlayerCommand command = new AddPlayerCommand(PlayerName, playerLevel);
            _addPlayerCommandHandler.Handle(command);

            LoadPlayers();
        }
        private void FindPlayer()
        {
            if (!int.TryParse(PlayerId, out int playerId))
            {
                SearchResult = "Niepoprawne ID";
                return;
            }

            GetPlayerByIdQuery query =
                new GetPlayerByIdQuery(playerId);

            Player? player =
                _getPlayerByIdQueryHandler.Handle(query);

            if (player == null)
            {
                SearchResult = "Nie znaleziono gracza";
                return;
            }

            SearchResult =
                $"{player.Name} - poziom {player.Level}";
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
        }

        private void LoadPlayers()
        {
<<<<<<< HEAD
            List<Player> players =
                _getPlayersQueryHandler.Handle(new GetPlayersQuery());

            Players.Clear();
            foreach (Player player in players)
                Players.Add(player);
        }

        protected void OnPropertyChanged(
            [CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(propertyName));
=======
            GetPlayersQuery query = new GetPlayersQuery();
            List<Player> players = _getPlayersQueryHandler.Handle(query);

            Players.Clear();

            foreach (Player player in players)
            {
                Players.Add(player);
            }
        }

        protected void OnPropertyChanged(
            [CallerMemberName] string?  propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
>>>>>>> fcdcebd710363bb5c73d48c5be8c8fa43c302918
        }
    }
}
