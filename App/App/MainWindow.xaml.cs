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

namespace App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void L_KeyDown(object sender, KeyEventArgs e)
        {
            double left = l.Margin.Left;
            double right = l.Margin.Right;
            double top = l.Margin.Top;
            double bottom = l.Margin.Bottom;
            switch (e.Key)
            {
                case Key.A:
                    left -= 2;
                    break;
                case Key.D:
                    left += 2;
                    break;
                //прыжок
                default:
                    break;
            }
            l.Margin = new Thickness(left, top, right, bottom);
        }
    }

        //private void L_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (Keyboard.IsKeyDown(Key.A))
        //    {
        //        l.Margin = new Thickness(-2, 0, 0, 0);
        //    }
        //    if (Keyboard.IsKeyDown(Key.D))
        //    {
        //        l.Margin = new Thickness(+2, 0, 0, 0);
        //    }
        //    if (Keyboard.IsKeyUp(Key.Space))
        //    {
        //        //прыжок
        //    }
        //    if (Keyboard.IsKeyUp(Key.A) && Keyboard.IsKeyUp(Key.W))
        //    {
        //        //прыжок
        //    }
        //    if (Keyboard.IsKeyUp(Key.D) && Keyboard.IsKeyUp(Key.W))
        //    {
        //        //прыжок
        //    }

        //}

}

   

