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

namespace GremlinQuestV1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Menu menu;
        public MainWindow()
        {
            menu = new Menu();
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            Testbox();
        }

        private void btnCredits_Click(object sender, RoutedEventArgs e)
        {
            menu.CreditsPage(btnPlay, btnCredits, btnBack, txtCredits);
            Testbox();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            menu.MainPage(btnPlay, btnCredits, btnBack, txtCredits);
            Testbox();
        }
        private void Testbox()
        {
            MessageBox.Show("test");
        }
    }
}
