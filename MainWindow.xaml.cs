using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticalWorkI
{
    public partial class MainWindow : Window
    {
        private string player_Symbol = "X";
        private string bot_Symbol = "O";
        private string[] board = new string[9];
        private Random random = new Random();
        private int symbol_Change;

        public MainWindow()
        {
            InitializeComponent();
            ResetBoard();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int i = Convert.ToInt32(button.Name.Substring(6)) - 1;
            if (board[i] == null)
            {
                board[i] = player_Symbol;
                button.Content = player_Symbol;
                if (!IsGameOver(player_Symbol))
                {
                    BotTurn();
                }
            }
        }

        private void BotTurn()
        {
            int i = random.Next(9);
            if (symbol_Change == 0)
            {
                while (board[i] != null)
                {
                    i = random.Next(9);
                    board[i] = player_Symbol;
                }
            }
            else board[i] = bot_Symbol;

            
            Button button = (Button)FindName("Button" + (i + 1));
            button.Content = bot_Symbol;
            IsGameOver(bot_Symbol);
        }

        private bool IsGameOver(string symbol)
        {
            if (
                (board[0] == symbol && board[1] == symbol && board[2] == symbol) ||
                (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
                (board[6] == symbol && board[7] == symbol && board[8] == symbol) ||
                (board[0] == symbol && board[3] == symbol && board[6] == symbol) ||
                (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
                (board[2] == symbol && board[5] == symbol && board[8] == symbol) ||
                (board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
                (board[2] == symbol && board[4] == symbol && board[6] == symbol)
            )
            {
                MessageBox.Show(symbol + " изнасиловал!");
                DisableButtons();
                return true;
            }
            if (board[0] != null && board[1] != null && board[2] != null &&
                board[3] != null && board[4] != null && board[5] != null &&
                board[6] != null && board[7] != null && board[8] != null)
            {
                MessageBox.Show("Ничья, родной, давай заново");
                DisableButtons();
                return true;
            }
            return false;
        }

        private void ResetBoard()
        {
            EnableButtons();

            for (int i = 0; i < 9; i++)
            {
                board[i] = null;
                Button button = (Button)FindName("Button" + (i + 1));
                if (button != null) button.Content = null;
            }
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            ResetBoard();
        }

        private void DisableButtons()
        {
            Button1.IsEnabled = false;
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;
            Button9.IsEnabled = false;
        }

        private void EnableButtons()
        {
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            Button9.IsEnabled = true;
        }
    }
}
