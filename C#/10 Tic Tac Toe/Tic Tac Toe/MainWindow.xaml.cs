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

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Deklaration of Player
        Player playerA;
        Player playerB;

        public MainWindow()
        {
            InitializeComponent();

            //Initialize Players and symbols 
            BitmapImage imgSourceA = new BitmapImage(new Uri("Cross.png", UriKind.Relative));
            BitmapImage imgSourceB = new BitmapImage(new Uri("Circle.png", UriKind.Relative));

            playerA = new Player(imgSourceA, 0, true);
            playerB = new Player(imgSourceB, 0, false);
        }

        #region Clicking_TopLine
        private void imgTopLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgTopLeft.Source != playerA.Symbol && imgTopLeft.Source != playerB.Symbol)
            {
                if (playerA.OnTurn == true)
                {
                    imgTopLeft.Source = playerA.Symbol;
                }
                else if (playerB.OnTurn == true)
                {
                    imgTopLeft.Source = playerB.Symbol;
                }

                CheckWinning();
                ChangePlayerOnTurn();
            }
        }

        private void imgTopMiddle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgTopMiddle.Source != playerA.Symbol && imgTopRight.Source != playerB.Symbol)
            {
                if (playerA.OnTurn == true)
                {
                    imgTopMiddle.Source = playerA.Symbol;
                }
                else if (playerB.OnTurn == true)
                {
                    imgTopMiddle.Source = playerB.Symbol;
                }

                CheckWinning();
                ChangePlayerOnTurn();
            }
        }

        private void imgTopRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgTopRight.Source != playerA.Symbol && imgTopRight.Source != playerB.Symbol)
            {
                if(playerA.OnTurn == true)
                {
                    imgTopRight.Source = playerA.Symbol;
                }
                else if (playerB.OnTurn == true)
                {
                    imgTopRight.Source = playerB.Symbol;
                }

                CheckWinning();
                ChangePlayerOnTurn();
            }
        }
        #endregion
        #region Clicking_MiddleLine
        private void imgMiddleLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgMiddleLeft.Source != playerA.Symbol && imgMiddleLeft.Source != playerB.Symbol)
            {
                if (playerA.OnTurn == true)
                {
                    imgMiddleLeft.Source = playerA.Symbol;
                }
                else if (playerB.OnTurn == true)
                {
                    imgMiddleLeft.Source = playerB.Symbol;
                }

                CheckWinning();
                ChangePlayerOnTurn();
            }
        }

        private void imgMiddleMiddle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgMiddleMiddle.Source != playerA.Symbol && imgMiddleMiddle.Source != playerB.Symbol)
            {
                if (playerA.OnTurn == true)
                {
                    imgMiddleMiddle.Source = playerA.Symbol;
                }
                else
                {
                    imgMiddleMiddle.Source = playerB.Symbol;
                }

                CheckWinning();
                ChangePlayerOnTurn();
            }
        }

        private void imgMiddleRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgMiddleRight.Source != playerA.Symbol && imgMiddleRight.Source != playerB.Symbol)
            {
                if (playerA.OnTurn == true)
                {
                    imgMiddleRight.Source = playerA.Symbol;
                }
                else if (playerB.OnTurn == true)
                {
                    imgMiddleRight.Source = playerB.Symbol;
                }

                CheckWinning();
                ChangePlayerOnTurn();
            }
        }
        #endregion
        #region Clicking_BottomLine
        private void imgBottomLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgBottomLeft.Source != playerA.Symbol && imgBottomLeft.Source != playerB.Symbol)
            {
                if (playerA.OnTurn == true)
                {
                    imgBottomLeft.Source = playerA.Symbol;
                }
                else if (playerB.OnTurn == true)
                {
                    imgBottomLeft.Source = playerB.Symbol;
                }

                CheckWinning();
                ChangePlayerOnTurn();
            }
        }

        private void imgBottomMiddle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgBottomMiddle.Source != playerA.Symbol && imgBottomMiddle.Source != playerB.Symbol)
            {
                if (playerA.OnTurn == true)
                {
                    imgBottomMiddle.Source = playerA.Symbol;
                }
                else if (playerB.OnTurn == true)
                {
                    imgBottomMiddle.Source = playerB.Symbol;
                }

                CheckWinning();
                ChangePlayerOnTurn();
            }
        }

        private void imgBottomRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (imgBottomRight.Source != playerA.Symbol && imgBottomRight.Source != playerB.Symbol)
            {
                if (playerA.OnTurn == true)
                {
                    imgBottomRight.Source = playerA.Symbol;
                }
                else if (playerB.OnTurn == true)
                {
                    imgBottomRight.Source = playerB.Symbol;
                }

                CheckWinning();
                ChangePlayerOnTurn();
            }
        }
        #endregion

        private void ChangePlayerOnTurn()
        {
            if(playerA.OnTurn == true)
            {
                playerA.OnTurn = false;
                playerB.OnTurn = true;
            }
            else if(playerB.OnTurn == true)
            {
                playerB.OnTurn = false;
                playerA.OnTurn = true;
            }
        }

        private void CheckWinning()
        {
            //Optionen zu Gewinnen
            //  - 1. Option: TopLeft | TopMiddle | TopRight
            //  - 2. Option: MiddleLeft | MiddleMiddle | MiddleRight
            //  - 3. Option: BottomLeft | BottomMiddle | BottomRight
            //  - 4. Option: TopLeft | MiddleLeft | BottomLeft
            //  - 5. Option: TopMiddle | MiddleMiddle | BottomMiddle
            //  - 6. Option: TopRight | MiddleRight | BottomRight
            //  - 7. Option: TopRight | MiddleMiddle | BottomLeft
            //  - 8. Option: TopLeft | MiddleMiddle | BottomRight

            #region Winning-Options_PlayerA
            if (imgTopLeft.Source == playerA.Symbol && imgTopMiddle.Source == playerA.Symbol && imgTopRight.Source == playerA.Symbol)
            {
                ProhibitSymbols();
                PlayerAWins();
            }
            else if (imgMiddleLeft.Source == playerA.Symbol && imgMiddleMiddle.Source == playerA.Symbol && imgMiddleRight.Source == playerA.Symbol)
            {
                ProhibitSymbols();
                PlayerAWins();
            }
            else if (imgBottomLeft.Source == playerA.Symbol && imgBottomMiddle.Source == playerA.Symbol && imgBottomRight.Source == playerA.Symbol)
            {
                ProhibitSymbols();
                PlayerAWins();
            }
            else if (imgTopLeft.Source == playerA.Symbol && imgMiddleLeft.Source == playerA.Symbol && imgBottomLeft.Source == playerA.Symbol)
            {
                ProhibitSymbols();
                PlayerAWins();
            }
            else if (imgTopMiddle.Source == playerA.Symbol && imgMiddleMiddle.Source == playerA.Symbol && imgBottomMiddle.Source == playerA.Symbol)
            {
                ProhibitSymbols();
                PlayerAWins();
            }
            else if (imgTopRight.Source == playerA.Symbol && imgMiddleRight.Source == playerA.Symbol && imgBottomRight.Source == playerA.Symbol)
            {
                ProhibitSymbols();
                PlayerAWins();
            }
            else if (imgTopRight.Source == playerA.Symbol && imgMiddleMiddle.Source == playerA.Symbol && imgBottomLeft.Source == playerA.Symbol)
            {
                ProhibitSymbols();
                PlayerAWins();
            }
            else if (imgTopLeft.Source == playerA.Symbol && imgMiddleMiddle.Source == playerA.Symbol && imgBottomRight.Source == playerA.Symbol)
            {
                ProhibitSymbols();
                PlayerAWins();
            }
            #endregion

            #region Winning-Options_PlayerB
            if (imgTopLeft.Source == playerB.Symbol && imgTopMiddle.Source == playerB.Symbol && imgTopRight.Source == playerB.Symbol)
            {
                ProhibitSymbols();
                PlayerBWins();
            }
            else if (imgMiddleLeft.Source == playerB.Symbol && imgMiddleMiddle.Source == playerB.Symbol && imgMiddleRight.Source == playerB.Symbol)
            {
                ProhibitSymbols();
                PlayerBWins();
            }
            else if (imgBottomLeft.Source == playerB.Symbol && imgBottomMiddle.Source == playerB.Symbol && imgBottomRight.Source == playerB.Symbol)
            {
                ProhibitSymbols();
                PlayerBWins();
            }
            else if (imgTopLeft.Source == playerB.Symbol && imgMiddleLeft.Source == playerB.Symbol && imgBottomLeft.Source == playerB.Symbol)
            {
                ProhibitSymbols();
                PlayerBWins();
            }
            else if (imgTopMiddle.Source == playerB.Symbol && imgMiddleMiddle.Source == playerB.Symbol && imgBottomMiddle.Source == playerB.Symbol)
            {
                ProhibitSymbols();
                PlayerBWins();
            }
            else if (imgTopRight.Source == playerB.Symbol && imgMiddleRight.Source == playerB.Symbol && imgBottomRight.Source == playerB.Symbol)
            {
                ProhibitSymbols();
                PlayerBWins();
            }
            else if (imgTopRight.Source == playerB.Symbol && imgMiddleMiddle.Source == playerB.Symbol && imgBottomLeft.Source == playerB.Symbol)
            {
                ProhibitSymbols();
                PlayerBWins();
            }
            else if (imgTopLeft.Source == playerB.Symbol && imgMiddleMiddle.Source == playerB.Symbol && imgBottomRight.Source == playerB.Symbol)
            {
                ProhibitSymbols();
                PlayerBWins();
            }
            #endregion
        }

        private void PlayerAWins()
        {
            MessageBox.Show("Herzlichen Glückwunsch, Spieler A hat gewonnen!", "Gewonnen");
            playerA.Scorepoints++;
            lblPointsA.Content = playerA.Scorepoints;
            btnPlayAgain.IsEnabled = true;
        }
        private void PlayerBWins()
        {
            MessageBox.Show("Herzlichen Glückwunsch, Spieler B hat gewonnen!", "Gewonnen");

            playerB.Scorepoints++;
            lblPointsB.Content = playerB.Scorepoints;
            btnPlayAgain.IsEnabled = true;
        }

        private void AllowSymbols()
        {
            imgTopLeft.IsEnabled = true;
            imgTopMiddle.IsEnabled = true;
            imgTopRight.IsEnabled = true;
            imgMiddleLeft.IsEnabled = true;
            imgMiddleMiddle.IsEnabled = true;
            imgMiddleRight.IsEnabled = true;
            imgBottomLeft.IsEnabled = true;
            imgBottomMiddle.IsEnabled = true;
            imgBottomRight.IsEnabled = true;
        }

        private void ProhibitSymbols()
        {
            imgTopLeft.IsEnabled = false;
            imgTopMiddle.IsEnabled = false;
            imgTopRight.IsEnabled = false;
            imgMiddleLeft.IsEnabled = false;
            imgMiddleMiddle.IsEnabled = false;
            imgMiddleRight.IsEnabled = false;
            imgBottomLeft.IsEnabled = false;
            imgBottomMiddle.IsEnabled = false;
            imgBottomRight.IsEnabled = false;
        }

        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            //Clear the symbols
            BitmapImage imgWhiteScreen = new BitmapImage(new Uri("WhiteScreen.jpg", UriKind.Relative));
            imgTopLeft.Source = imgWhiteScreen;
            imgTopMiddle.Source = imgWhiteScreen;
            imgTopRight.Source = imgWhiteScreen;
            imgMiddleLeft.Source = imgWhiteScreen;
            imgMiddleMiddle.Source = imgWhiteScreen;
            imgMiddleRight.Source = imgWhiteScreen;
            imgBottomLeft.Source = imgWhiteScreen;
            imgBottomMiddle.Source = imgWhiteScreen;
            imgBottomRight.Source = imgWhiteScreen;

            AllowSymbols();

            btnPlayAgain.IsEnabled = false;
        }
    }
}