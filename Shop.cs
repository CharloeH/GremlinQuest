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
    class Shop
    {
        public bool ShopOpen = false;
        public Canvas CShop;
        private StackPanel sp;

        public Canvas GenerateShop(StackPanel SPWindow)
        {
            sp = SPWindow;
            //creates shop
            CShop = new Canvas();
            CShop.Background = Brushes.Red;
            CShop.Height = 650;
            CShop.Width = 1000;
            CShop.HorizontalAlignment = HorizontalAlignment.Center;

            
            return CShop;
        }

        public void AddItem()
        {

        }

        public void OpenShopWindow(Button btnShop)
        {
            btnShop.Content = "Close Shop";
            sp.Children.Add(CShop);
            ShopOpen = true;
            //Console.WriteLine("Shop open");
        }

        public void CloseShopWindow(Button btnShop)
        {
            sp.Children.RemoveAt(sp.Children.IndexOf(CShop));
            btnShop.Content = "Open Shop";
            ShopOpen = false;
            //Console.WriteLine("Shop not open");
        }
    }
}
