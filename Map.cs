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
        public void GenerateMap(StackPanel sp, Rectangle r)
        {
            sp.Children.Add(r);
            r.Fill = Brushes.Red;
            r.Height = 650;
            r.Width = 1000;
            r.HorizontalAlignment = HorizontalAlignment.Center;

        }
    }
}
