using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFishGame
{
    class Game
    {
        private string text;
        private List<string> list;
        private TextBox textProgress;

        public Game(string text, List<string> list, TextBox textProgress)
        {
            this.text = text;
            this.list = list;
            this.textProgress = textProgress;
        }
    }
}
