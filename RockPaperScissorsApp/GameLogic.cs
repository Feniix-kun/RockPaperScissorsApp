using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RockPaperScissorsApp
{
    internal class GameLogic
    {
        private string PlayerChoice;
        private string EnemyChoice;
        private Dictionary<int, string> VariantsEnemyChoice;
        private Dictionary<string, string> LocaleChoice;
        private Random random = new Random();
        public ICommand OnChoisePlayerCommand { get; }

        GameViewModel GameViewModel;
        public GameLogic(GameViewModel gameDataModel)
        {
            GameViewModel = gameDataModel;
            OnChoisePlayerCommand = new RelayCommand(OnPlayerChoice);
            VariantsEnemyChoice = new Dictionary<int, string>()
            {
                {1, "Rock" },
                {2, "Paper" },
                {3, "Scissors" }
            };
            LocaleChoice = new Dictionary<string, string>()
            {
                {"Rock", "Камень"},
                {"Paper", "Бумага" },
                {"Scissors", "Ножницы"}
            };
        }
        public void OnPlayerChoice(object parameter)
        {
            if (parameter is string choice)
            {
                PlayerChoice = choice;
                GamePlay();
            }
        }

        private void GamePlay()
        {
            EnemyChoice = VariantsEnemyChoice[random.Next(1, 4)];

            if (PlayerChoice == EnemyChoice)
            {
                UpdateGameData("Ничья");
            }
            else if ((PlayerChoice == "Rock" && EnemyChoice == "Scissors") ||
                     (PlayerChoice == "Paper" && EnemyChoice == "Rock") ||
                     (PlayerChoice == "Scissors" && EnemyChoice == "Paper"))
            {
                UpdateGameData("Победа");
            }
            else
            {
                UpdateGameData("Поражение");
            }
        }
        private void UpdateGameData(string resultValue)
        {
            GameViewModel.ResultValue = resultValue;
            GameViewModel.EnemyChoice = LocaleChoice[EnemyChoice];
            GameViewModel.PlayerChoice = LocaleChoice[PlayerChoice];
        }
    }
}
