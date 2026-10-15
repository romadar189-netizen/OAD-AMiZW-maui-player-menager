
using MauiApp3.Commands;
using MauiApp3.Model;
using MauiApp3.Queries;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
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
>>>>>>> fad0de232215eb6968a828c6e703b465d7d19ac2

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Player> Players { get; } = new();
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
<<<<<<< HEAD
        public ICommand DeletePlayerCommandButton { get; }
        public ICommand FindPlayerCommandButton { get; }
        public ICommand EditPlayerCommandButton { get;}
        public MainViewModel(
            GetPlayerByIdQueryHandler getPlayerByIdQueryHandler,
            GetPlayersQueryHandler getPlayersQueryHandler,
            AddPlayerCommandHandler addPlayerCommandHandler,
            DeletePlayerCommandHandler deletePlayerCommandHandler,
            EditPlayerCommandHandler editPlayerCommandHandler
            )
=======
        public ICommand FindPlayerCommandButton { get; }
        public MainViewModel(
            GetPlayerByIdQueryHandler getPlayerByIdQueryHandler,
            GetPlayersQueryHandler getPlayersQueryHandler,
            AddPlayerCommandHandler addPlayerCommandHandler)
>>>>>>> fad0de232215eb6968a828c6e703b465d7d19ac2
        {
            _getPlayerByIdQueryHandler = getPlayerByIdQueryHandler;
            _getPlayersQueryHandler = getPlayersQueryHandler;
            _addPlayerCommandHandler = addPlayerCommandHandler;
<<<<<<< HEAD
            _deletePlayerCommandHandler = deletePlayerCommandHandler;
            _editPlayerCommandHandler = editPlayerCommandHandler;

            AddPlayerCommandButton = new Command(AddPlayer);
            DeletePlayerCommandButton = new Command(DeletePlayer);
            FindPlayerCommandButton = new Command(FindPlayer);
            EditPlayerCommandButton = new Command(EditPlayer);
=======

            AddPlayerCommandButton = new Command(AddPlayer);
            FindPlayerCommandButton = new Command(FindPlayer);
>>>>>>> fad0de232215eb6968a828c6e703b465d7d19ac2


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
<<<<<<< HEAD
        private void DeletePlayer()
        {
            if(!int.TryParse(PlayerId, out int playerId))
            {
                return;
            }
            DeletePlayerCommand command = new DeletePlayerCommand(playerId);
            _deletePlayerCommandHandler.Handle(command);

            LoadPlayers();
        }
        private void EditPlayer()
        {
    // Sprawdzenie Id gracza
            if (!int.TryParse(PlayerId, out int playerId) || playerId <= 0)
            {
                SearchResult = "Podaj poprawne ID gracza.";
                return;
            }

    // Sprawdzenie nazwy
            if (string.IsNullOrWhiteSpace(PlayerName))
            {
                SearchResult = "Nazwa gracza nie może być pusta.";
                return;
            }

    // Sprawdzenie poziomu
            if (!int.TryParse(PlayerLevel, out int playerLevel) || playerLevel < 0)
            {
                SearchResult = "Podaj poprawny poziom gracza.";
                return;
            }

    // Utworzenie polecenia edycji
            EditPlayerCommand command = new EditPlayerCommand(
            playerId,
            PlayerName.Trim(),
            playerLevel
            );

    // Przekazanie polecenia do handlera
            _editPlayerCommandHandler.Handle(command);
            SearchResult = "Gracz został zaktualizowany.";

    // Odświeżenie listy graczy
            LoadPlayers();
}
=======
>>>>>>> fad0de232215eb6968a828c6e703b465d7d19ac2
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
        }

        private void LoadPlayers()
        {
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
        }
    }
}
