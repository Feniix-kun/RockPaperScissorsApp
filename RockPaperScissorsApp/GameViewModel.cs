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
        public int winValue = 0;
        public int loseValue = 0;
        public int drawValue = 0;
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
        public int WinValue
        {
            get => winValue;
            set
            {
                if (winValue != value)
                {
                    winValue = value;
                    OnPropertyChanged(nameof(WinValue));
                }
            }
        }
        public int LoseValue
        {
            get => loseValue;
            set
            {
                if (loseValue != value)
                {
                    loseValue = value;
                    OnPropertyChanged(nameof(LoseValue));
                }
            }
        }
        public int DrawValue
        {
            get => drawValue;
            set
            {
                if (drawValue != value)
                {
                    drawValue = value;
                    OnPropertyChanged(nameof(DrawValue));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
