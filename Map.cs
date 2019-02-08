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
    class Map
    {
        public Point WallPoint = new Point(0,0);
        public void GenerateMap(Canvas c, StackPanel sp)
        {
            c.Background = Brushes.DarkRed;
            c.Height = 650;
            c.Width = 1000;
            c.HorizontalAlignment = HorizontalAlignment.Center;
            sp.Children.Add(c);
        }
    }
}
