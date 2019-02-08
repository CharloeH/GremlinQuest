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
namespace GremlinQuest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Shop shop;
        Menu menu;
        Point playerPoint;
        Player player;
        Map map;
        
        public bool isMove;
        DispatcherTimer GameTimer;
        Rectangle PlayerRectangle;
        public Rectangle MapRectangle;
        public bool isGenerated = false;
        
        public MainWindow()
        {
            shop = new Shop();
            menu = new Menu();
            player = new Player();
            map = new Map();
            
            GameTimer = new DispatcherTimer();
            MapRectangle = new Rectangle();
            PlayerRectangle = new Rectangle();
            playerPoint = new Point(500,500);
            
            InitializeComponent();
            
            shop.GenerateShop(SPWindow);

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
            if (shop.ShopOpen)
            {
                shop.CloseShopWindow(BtnShop);
            }
            else if (shop.ShopOpen == false) 
            {
                shop.OpenShopWindow(BtnShop);
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

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
