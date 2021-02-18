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
        Game game = new Game();

        public MainWindow()
        {
            InitializeComponent();
            pressedOnce = false;
        }

        public void buttonGo_Click(object sender, RoutedEventArgs e)
        {

            if (pressedOnce == false)
            {
                if (checkBoxEasy.IsChecked == true)
                {
                    game.RandomNum(1,11);
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
















        }
    }
}
