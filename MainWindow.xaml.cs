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
        //Class Declaration
        Menu menu;
        public bool ShopOpen = false;
        public Canvas CShop;

        public MainWindow()
        {
            menu = new Menu();
            InitializeComponent();

            //needs moved to shop class
            CShop = new Canvas();
            CShop.Background = Brushes.Red;
            CShop.Height = 650;
            CShop.Width = 1000;
            CShop.HorizontalAlignment = HorizontalAlignment.Center;
        }

        private void BtnShop_Click(object sender, RoutedEventArgs e)
        {
            if (ShopOpen)
            {
                CloseShopWindow(SPWindow);
            }
            else if (ShopOpen == false)
            {
                OpenShopWindow(SPWindow);
            }
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

        //needs moved to shop class, requires references.
        public void OpenShopWindow(StackPanel Window)
        {
            BtnShop.Content = "Close Shop";
            SPWindow.Children.Add(CShop);
            ShopOpen = true;
            //troubleshooting lblConsole.Content = "Shop open";
        }

        public void CloseShopWindow(StackPanel Window)
        {
            int temp = Window.Children.IndexOf(CShop);
            Window.Children.RemoveAt(temp);
            BtnShop.Content = "Open Shop";
            ShopOpen = false;
            //troubleshooting lblConsole.Content = "Shop not open";
        }
    }
}
