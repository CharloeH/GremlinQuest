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

namespace GremlinQuest
{
    class Menu
    {
        public void MainPage(Button btnCredits, Button btnPlay, Button btnBack, TextBlock txtCredits)
        {
            btnCredits.Visibility = Visibility.Visible;
            btnPlay.Visibility = Visibility.Visible;
            txtCredits.Visibility = Visibility.Hidden;
            btnBack.Visibility = Visibility.Hidden;
        }
        public void CreditsPage(Button btnCredits, Button btnPlay, Button btnBack, TextBlock txtCredits)
        {
            btnCredits.Visibility = Visibility.Hidden;
            btnPlay.Visibility = Visibility.Hidden;
            txtCredits.Visibility = Visibility.Visible;
            btnBack.Visibility = Visibility.Visible;
        }
        public void HideAll(Button btnCredits, Button btnPlay, Button btnBack, TextBlock txtCredits)
        {
            btnBack.Visibility = Visibility.Hidden;
            btnPlay.Visibility = Visibility.Hidden;
            btnCredits.Visibility = Visibility.Hidden;
            txtCredits.Visibility = Visibility.Hidden;
        }
        public void Testbox()
        {
            //MessageBox.Show("test");
        }
    }
    }
