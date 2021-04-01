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

namespace App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double left;
        double right;
        double top;
        double bottom;
        public MainWindow()
        {
            InitializeComponent();
            left = l.Margin.Left;
            right = l.Margin.Right;
            top = l.Margin.Top;
            bottom = l.Margin.Bottom;
        }

        private DispatcherTimer timer = null;
        private int x;

        private void timerStart(int k)
        {
            timer = new DispatcherTimer();
            switch (k)
            {
                case 0:
                    {
                        timer.Tick += new EventHandler(dispatcherTimer_Tick);
                        break;
                    }
                case 1:
                    {
                        
                            timer.Tick += new EventHandler(dispatcherTimer_Tick1);
                            break;
                        
                    }
                case 2:
                    {
                        timer.Tick += new EventHandler(dispatcherTimer_Tick2);
                        break;
                    }
            }
            timer.Tick += new EventHandler(dispatcherTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void dispatcherTimer_Tick2(object sender, EventArgs e)
        {

            int n = 0;
            if (n > 6) { top += 2; left -= 1; n++; } else { top -= 2; left -= 1; n++; }
            l.Margin = new Thickness(left, top, right, bottom);

        }
        private void dispatcherTimer_Tick1(object sender, EventArgs e)
        {

            int n = 0;
            if (n > 6) { top += 2; left += 1; n++; } else { top -= 2; left += 1; n++; }
            l.Margin = new Thickness(left, top, right, bottom);

        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
          
                        
                       
            int n = 0;
            if (n > 6) { top += 2; n++; } else { top -= 2; n++; }
            l.Margin = new Thickness(left, top, right, bottom);

        }
        private void L_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (Keyboard.IsKeyDown(Key.A))
            {
                left -= 2;
                l.Margin = new Thickness(left, top, right, bottom);
            }
            if (Keyboard.IsKeyDown(Key.D))
            {
                left += 2;
                l.Margin = new Thickness(left, top, right, bottom);
            }
            if (Keyboard.IsKeyUp(Key.W))
            {
                timerStart(0);
            }
            if (Keyboard.IsKeyUp(Key.A) && Keyboard.IsKeyUp(Key.W))
            {
                timerStart(1);
            }
            if (Keyboard.IsKeyUp(Key.D) && Keyboard.IsKeyUp(Key.W))
            {
                timerStart(2);
            }
            
        }
    }



}

   

