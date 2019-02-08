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
    class Player
    {
        public Rectangle playerRectangle = new Rectangle();
        public Point playerPoint = new Point();
        public Point PlayerMove (Rectangle pRectangle, Point pP, bool isMove)
        {
            if (isMove == true)
            {
                playerPoint = pP;
                if (Keyboard.IsKeyDown(Key.W))
                {
                    DisplayCordinates();
                    pP.Y -= 10;

                }
                if (Keyboard.IsKeyDown(Key.S))
                {
                    DisplayCordinates();
                    pP.Y += 10;
                }
                if (Keyboard.IsKeyDown(Key.A))
                {
                    DisplayCordinates();
                    pP.X -= 10;
                }
                if (Keyboard.IsKeyDown(Key.D))
                {
                    DisplayCordinates();
                    pP.X += 10;
                }
                Canvas.SetLeft(playerRectangle, playerPoint.X);
                Canvas.SetTop(playerRectangle, playerPoint.Y);
            }
                
            else 
            {
               // MessageBox.Show("nope");
            }
            return pP;
        }

        public void GeneratePlayer(Canvas c, Point pP)
        {
            playerPoint = pP;
            playerRectangle.Height = 50;
            playerRectangle.Width = 50;
            playerRectangle.Fill = Brushes.Blue;
            c.Children.Add(playerRectangle);
            Canvas.SetLeft(playerRectangle, playerPoint.X);
            Canvas.SetTop(playerRectangle, playerPoint.Y);
        }
        public void DisplayCordinates()
        {
            Console.WriteLine(playerPoint);
        }
    }
}
