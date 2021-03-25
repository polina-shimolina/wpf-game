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
    {public:
        double left = l.Margin.Left;
        double right = l.Margin.Right;
        double top = l.Margin.Top;
        double bottom = l.Margin.Bottom;
        public MainWindow()
        {
            InitializeComponent();
        }

        private DispatcherTimer timer = null;
        private int x;

        private void timerStart()
        {
            timer = new DispatcherTimer(); 
            timer.Tick += new EventHandler(dispatcherTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void dispatcherTimer_Tick()
        { 
            int n = 0;
            if (n > 6) { top += 2; n++; } else { top -= 2; n++; } 
            
            
        }
        private void L_KeyDown(object sender, KeyEventArgs e)
        {
            double left = l.Margin.Left;
            double right = l.Margin.Right;
            double top = l.Margin.Top;
            double bottom = l.Margin.Bottom;

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
                
            }
            if (Keyboard.IsKeyUp(Key.A) && Keyboard.IsKeyUp(Key.W))
            {
                
            }
            if (Keyboard.IsKeyUp(Key.D) && Keyboard.IsKeyUp(Key.W))
            {
                
            }
            
        }
    }



}

   

