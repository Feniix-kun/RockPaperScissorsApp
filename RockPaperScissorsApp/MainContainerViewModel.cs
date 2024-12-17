using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    internal class MainContainerViewModel
    {
        public GameLogic GameLogic { get; set; }
        public GameViewModel GameViewModel { get; set; }
        public MainContainerViewModel()
        {
            GameViewModel = new GameViewModel();
            GameLogic = new GameLogic(GameViewModel);
        }
    }
}
