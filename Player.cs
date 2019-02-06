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
    class Player
    {
        public Rectangle playerRectangle = new Rectangle();
        public Point playerPoint = new Point();
        public Point PlayerMove (Rectangle pRectangle, Point pP)
        {
            playerPoint = pP;
            if (Keyboard.IsKeyDown(Key.W))
            {
                pP.Y = pP.Y - 10;
            }
            return pP;
        }

        public void GeneratePlayer(Canvas canvas, Point pP)
        {
            playerPoint = pP;
            playerRectangle.Height = 50;
            playerRectangle.Width = 50;
            playerRectangle.Fill = Brushes.Red;
            canvas.Children.Add(playerRectangle);
            Canvas.SetLeft(playerRectangle, playerPoint.X);
            Canvas.SetTop(playerRectangle, playerPoint.Y);
        }

    }
}
