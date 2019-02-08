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
using System.Windows.Threading;
namespace GremlinQuestV1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Class Declaration

        public bool isMove;
        DispatcherTimer GameTimer;
        Rectangle PlayerRectangle;
        public Rectangle MapRectangle;
        Menu menu;
        Point playerPoint;
        Player player;
        Map map;
        public bool ShopOpen = false;
        public bool isGenerated = false;
        public Canvas CShop;
        public MainWindow()
        {
            GameTimer = new DispatcherTimer();
            MapRectangle = new Rectangle();
            PlayerRectangle = new Rectangle();
            playerPoint = new Point(500,500);
            menu = new Menu();
            player = new Player();
            map = new Map();
            InitializeComponent();

            //Generating player
            if (isGenerated == false)
            {
                map.GenerateMap(SPWindow, MapRectangle);
                player.GeneratePlayer(Canvas, playerPoint);
                isGenerated = true;
                isMove = true;
            }
            //Gametimer
            GameTimer.Tick += GameTimer_tick;
            GameTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 60);//fps
            GameTimer.Start();

            //needs moved to shop class
            CShop = new Canvas();
            CShop.Background = Brushes.Red;
            CShop.Height = 650;
            CShop.Width = 1000;
            CShop.HorizontalAlignment = HorizontalAlignment.Center;
        }
        private void GameTimer_tick(object sender, EventArgs e)
        {
            player.PlayerMove(PlayerRectangle, playerPoint, isMove);
            playerPoint = player.PlayerMove(PlayerRectangle, playerPoint, isMove);
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
            menu.HideAll(btnBack, btnPlay, btnCredits, txtCredits);
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
            //MessageBox.Show("test");
        }

        //needs moved to shop class, requires references.
        public void OpenShopWindow(StackPanel Window)
        {
            BtnShop.Content = "Close Shop";
            SPWindow.Children.Add(CShop);
            ShopOpen = true;
            //troubleshooting lblConsole.Content = "Shop open";
            isMove = false;
        }

        public void CloseShopWindow(StackPanel Window)
        {
            int temp = Window.Children.IndexOf(CShop);
            Window.Children.RemoveAt(temp);
            BtnShop.Content = "Open Shop";
            ShopOpen = false;
            //troubleshooting lblConsole.Content = "Shop not open";
            isMove = true;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
