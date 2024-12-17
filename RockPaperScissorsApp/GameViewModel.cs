using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public string enemyChoice;
        public string playerChoice;
        public string resultValue;
        public event PropertyChangedEventHandler PropertyChanged;

        public string EnemyChoice
        {
            get => enemyChoice;
            set
            {
                if (enemyChoice != value)
                {
                    enemyChoice = value;
                    OnPropertyChanged(nameof(EnemyChoice));
                }
            }
        }

        public string PlayerChoice
        {
            get => playerChoice;
            set
            {
                if (playerChoice != value)
                {
                    playerChoice = value;
                    OnPropertyChanged(nameof(PlayerChoice));
                }
            }
        }

        public string ResultValue
        {
            get => resultValue;
            set
            {
                if (resultValue != value)
                {
                    resultValue = value;
                    OnPropertyChanged(nameof(ResultValue));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
