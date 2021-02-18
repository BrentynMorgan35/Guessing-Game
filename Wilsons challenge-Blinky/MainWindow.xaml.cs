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



namespace Wilsons_challenge_Blinky
{
    public partial class MainWindow : Window
    {
        public bool pressedOnce;
        Game game;
        string[] x;

        public MainWindow()
        {
            InitializeComponent();
            pressedOnce = false;
            x = new string[3];

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
          

            if (pressedOnce == false)
            {
                game = new Game();
                if (checkBoxEasy.IsChecked == true)
                {
                    game.RandomNum(1, 11);
                    pressedOnce = true;
                }
                else if (checkBoxMedium.IsChecked == true)
                {
                    game.RandomNum(1, 101);
                    pressedOnce = true;
                }
                else if (checkBoxHard.IsChecked == true)
                {
                    game.RandomNum(1, 10001);
                    pressedOnce = true;
                }
            }

                game.Guess(int.Parse(p1.Text), int.Parse(p2.Text), int.Parse(p3.Text));

                if (int.Parse(p1.Text)<game.randomNum)
                {
                    p1t.Content = "Higher";
                  
                }else if (int.Parse(p1.Text) > game.randomNum)
                {
                    p1t.Content = "Lower";
                }
                else if (int.Parse(p1.Text) == game.randomNum)
                {
                    p1t.Content = "Correct";
                    x = game.GameEnd();
                player1print.Content = x[0];
                player2print.Content = x[1];
                player3print.Content = x[2];
                btn.IsEnabled = false;
            }


                if (int.Parse(p2.Text) < game.randomNum)
                {
                    p2t.Content = "Higher";
                }
                else if (int.Parse(p2.Text) > game.randomNum)
                {
                    p2t.Content = "Lower";
                }
                else if (int.Parse(p2.Text) == game.randomNum)
                {
                    p2t.Content = "Correct";
                    x = game.GameEnd();
                player1print.Content = x[0];
                player2print.Content = x[1];
                player3print.Content = x[2];
                btn.IsEnabled = false;
            }

                if (int.Parse(p3.Text) < game.randomNum)
                {
                    p3t.Content = "Higher";
                }
                else if (int.Parse(p3.Text) > game.randomNum)
                {
                    p3t.Content = "Lower";
                }
                else if (int.Parse(p3.Text) == game.randomNum)
                {
                    p3t.Content = "Correct";
                    x = game.GameEnd();
                player1print.Content = x[0];
                player2print.Content = x[1];
                player3print.Content = x[2];
                btn.IsEnabled = false;
            }











            
















        }

    }
}
